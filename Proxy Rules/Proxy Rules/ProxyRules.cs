using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proxy_Rules
{
    public partial class ProxyRules : Form
    {
        private static Mutex mutex = null;
        private const string appName = "ProxyRulesApp";
        private List<ProxyRule> proxyRules;
        private Process proxyProcess;
        
        public ProxyRules()
        {
            // Verificar instancia única
            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("La aplicación ya está en ejecución.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

            // Verificar privilegios de administrador
            if (!IsRunAsAdministrator())
            {
                try
                {
                    ProcessStartInfo proc = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        WorkingDirectory = Environment.CurrentDirectory,
                        FileName = Application.ExecutablePath,
                        Verb = "runas"
                    };
                    Process.Start(proc);
                }
                catch
                {
                    MessageBox.Show("Se requieren privilegios de administrador para ejecutar esta aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Environment.Exit(0);
            }

            InitializeComponent();
            proxyRules = new List<ProxyRule>();
            LoadProxyRules();

        }

        private bool IsRunAsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void ShowLogs(string message, string type = "info")
        {
            switch (type)
            {
                case "info":
                    LogsLabel.Text = message;
                    LogsLabel.ForeColor = System.Drawing.Color.White;
                    break;
                case "success":
                    LogsLabel.Text = message;
                    LogsLabel.ForeColor = System.Drawing.Color.Green;
                    break;
                case "error":
                    LogsLabel.Text = message;
                    LogsLabel.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    LogsLabel.Text = message;
                    LogsLabel.ForeColor = System.Drawing.Color.White;
                    break;
            }
        }

        private void CloseControlBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeControlBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadProxyRules()
        {
            try
            {
                if (File.Exists("proxy_rules.json"))
                {
                    var json = File.ReadAllText("proxy_rules.json");
                    var data = JsonConvert.DeserializeObject<Dictionary<string, List<ProxyRule>>>(json);
                    proxyRules = data?["rules"] ?? new List<ProxyRule>();
                }
                else
                {
                    proxyRules = new List<ProxyRule>();
                    SaveProxyRules();
                }

                ListProxyRules.Items.Clear();
                foreach (var rule in proxyRules)
                {
                    ListProxyRules.Items.Add(rule.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rules: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                proxyRules = new List<ProxyRule>();
            }
        }

        private void SaveProxyRules()
        {
            try
            {
                var data = new Dictionary<string, List<ProxyRule>>
                {
                    { "rules", proxyRules }
                };
                var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText("proxy_rules.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving rules: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class ProxyRule
        {
            public string Name { get; set; }
            public string HostPattern { get; set; }
            public string UrlPattern { get; set; }
            public string MatchType { get; set; }
            public string HttpMethod { get; set; }
            public dynamic Response { get; set; }
            public bool IsEnabled { get; set; }
        }

 private void ListProxyRules_SelectedIndexChanged(object sender, EventArgs e)
{
    if (ListProxyRules.SelectedItem != null)
    {
        string selectedRuleName = ListProxyRules.SelectedItem.ToString();
        ProxyRule selectedRule = proxyRules.Find(rule => rule.Name == selectedRuleName);

        if (selectedRule != null)
        {
            NameRuleInput.Text = selectedRule.Name;
            UrlInput.Text = (selectedRule.HostPattern + selectedRule.UrlPattern);
            MatchTypeSelect.SelectedItem = selectedRule.MatchType;
            MethodHttpSelect.SelectedItem = selectedRule.HttpMethod;
            ActiveRuleSwitch.Checked = selectedRule.IsEnabled;
            NewResponseInput.Text = JsonConvert.SerializeObject(selectedRule.Response, Formatting.Indented);
        }
    }
}

private void SaveChangesBtn_Click(object sender, EventArgs e)
{
    string ruleName = NameRuleInput.Text.Trim();
    string fullUrl = UrlInput.Text.Trim();
    string matchType = MatchTypeSelect.SelectedItem?.ToString();
    string httpMethod = MethodHttpSelect.SelectedItem?.ToString();
    string responseText = NewResponseInput.Text.Trim();

    if (string.IsNullOrEmpty(ruleName) || string.IsNullOrEmpty(fullUrl) ||
        string.IsNullOrEmpty(matchType) || string.IsNullOrEmpty(httpMethod) || string.IsNullOrEmpty(responseText))
    {
        ShowLogs("Please fill in all fields.", "error");
        return;
    }

    var allowedMatchTypes = new[] { "Exact", "StartsWith", "EndsWith", "Contains" };
    var allowedHttpMethods = new[] { "GET", "POST" };

    if (!allowedMatchTypes.Contains(matchType))
    {
        ShowLogs("Invalid match type.", "error");
        return;
    }

    if (!allowedHttpMethods.Contains(httpMethod))
    {
        ShowLogs("Invalid HTTP method.", "error");
        return;
    }

    dynamic response;
    try
    {
        response = JsonConvert.DeserializeObject(responseText);
    }
    catch (JsonException)
    {
        ShowLogs("Invalid JSON in response.", "error");
        return;
    }

    // Remove scheme (http:// or https://) from the URL
    fullUrl = fullUrl.Replace("http://", "").Replace("https://", "");

    Uri uri;
    try
    {
        uri = new Uri("http://" + fullUrl); // Add scheme temporarily for parsing
    }
    catch (UriFormatException)
    {
        ShowLogs("Invalid URL format.", "error");
        return;
    }

    string hostPattern = uri.GetLeftPart(UriPartial.Authority).Replace("http://", "").Replace("https://", "");
    string urlPattern = uri.PathAndQuery;

    ProxyRule existingRule = proxyRules.Find(rule => rule.Name.Equals(ruleName, StringComparison.OrdinalIgnoreCase));

    if (existingRule != null)
    {
        // Update existing rule
        existingRule.HostPattern = hostPattern;
        existingRule.UrlPattern = urlPattern;
        existingRule.MatchType = matchType;
        existingRule.HttpMethod = httpMethod;
        existingRule.Response = response;
        existingRule.IsEnabled = ActiveRuleSwitch.Checked;
        ShowLogs("Rule updated successfully.", "success");
    }
    else
    {
        // Add new rule
        ProxyRule newRule = new ProxyRule
        {
            Name = ruleName,
            HostPattern = hostPattern,
            UrlPattern = urlPattern,
            MatchType = matchType,
            HttpMethod = httpMethod,
            Response = response,
            IsEnabled = ActiveRuleSwitch.Checked
        };
        proxyRules.Add(newRule);
        ListProxyRules.Items.Add(newRule.Name);
        ShowLogs("Rule added successfully.", "success");
    }

    SaveProxyRules();
}

private void DeleteRuleBtn_Click(object sender, EventArgs e)
{
    if (ListProxyRules.SelectedItem != null)
    {
        string selectedRuleName = ListProxyRules.SelectedItem.ToString();
        ProxyRule ruleToDelete = proxyRules.Find(rule => rule.Name.Equals(selectedRuleName, StringComparison.OrdinalIgnoreCase));

        if (ruleToDelete != null)
        {
            proxyRules.Remove(ruleToDelete);
            ListProxyRules.Items.Remove(selectedRuleName);
            SaveProxyRules();
            ShowLogs("Regla eliminada correctamente.", "success");
        }
        else
        {
            ShowLogs("La regla seleccionada no existe.", "error");
        }
    }
    else
    {
        ShowLogs("No hay ninguna regla seleccionada para eliminar.", "error");
    }
}

        private void ActiveRuleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ListProxyRules.SelectedItem != null)
            {
                string selectedRuleName = ListProxyRules.SelectedItem.ToString();
                ProxyRule selectedRule = proxyRules.Find(rule => rule.Name == selectedRuleName);

                if (selectedRule != null)
                {
                    selectedRule.IsEnabled = ActiveRuleSwitch.Checked;
                    SaveProxyRules();
                }
            }
        }

        private async void ProxySwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ProxySwitch.Checked)
            {
                try
                {
                    if (proxyProcess == null || proxyProcess.HasExited)
                    {
                        string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bypass Exploits.exe");
                        if (!File.Exists(exePath))
                        {
                            ShowLogs("Archivo Bypass Exploits.exe no encontrado.", "error");
                            ProxySwitch.Checked = false;
                            return;
                        }

                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = exePath,
                            UseShellExecute = true,
                            CreateNoWindow = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        };
                        proxyProcess = new Process
                        {
                            StartInfo = startInfo,
                            EnableRaisingEvents = true
                        };
                        proxyProcess.Exited += ProxyProcess_Exited;
                        proxyProcess.Start();
                        ShowLogs("Proxy habilitado.", "success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al iniciar el proxy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowLogs("Error al iniciar el proxy", "error");
                    ProxySwitch.Checked = false;
                }
            }
            else
            {
                CloseProxy();
            }
        }

        private void ProxyProcess_Exited(object sender, EventArgs e)
        {
            // Registrar en logs que el proceso se ha cerrado
            ShowLogs("Bypass Exploits.exe ha finalizado inesperadamente.", "error");

            // Actualizar el estado del ProxySwitch en el hilo principal
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => ProxySwitch.Checked = false));
            }
            else
            {
                ProxySwitch.Checked = false;
            }
        }

        private async void CloseProxy()
        {
            try
            {
                // Ejecutar Bypass Exploits.exe con el argumento -Close y solicitar elevación
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "Bypass Exploits.exe",
                    Arguments = "-Close",
                    UseShellExecute = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Verb = "runas" // Solicitar privilegios de administrador
                };
                Process closeProcess = Process.Start(startInfo);

                // Esperar de forma asíncrona a que el proceso termine
                await Task.Run(() => closeProcess.WaitForExit());

                // Cerrar el proceso Bypass Exploits.exe si sigue en ejecución
                if (proxyProcess != null && !proxyProcess.HasExited)
                {
                    proxyProcess.Kill();
                    proxyProcess.Dispose();
                    proxyProcess = null;
                }

                ShowLogs("Proxy cerrado mediante comando.", "info");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar el proxy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowLogs("Error al cerrar el proxy", "error");
            }
        }
    }
}