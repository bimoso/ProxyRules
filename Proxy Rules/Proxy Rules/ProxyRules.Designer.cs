using System.ComponentModel;

namespace Proxy_Rules;

partial class ProxyRules
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        if (mutex != null)
        {
            mutex.ReleaseMutex();
            mutex = null;
        }

        // Detener Bypass Exploits.exe al cerrar la aplicación
        if (proxyProcess != null && !proxyProcess.HasExited)
        {
            proxyProcess.Kill();
            proxyProcess = null;
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
        CloseControlBtn = new Guna.UI2.WinForms.Guna2Button();
        MinimizeControlBtn = new Guna.UI2.WinForms.Guna2Button();
        ListProxyRules = new System.Windows.Forms.ListBox();
        guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        label7 = new System.Windows.Forms.Label();
        NewResponseInput = new Guna.UI2.WinForms.Guna2TextBox();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        ProxySwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
        UrlInput = new Guna.UI2.WinForms.Guna2TextBox();
        NameRuleInput = new Guna.UI2.WinForms.Guna2TextBox();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        MethodHttpSelect = new System.Windows.Forms.ComboBox();
        MatchTypeSelect = new System.Windows.Forms.ComboBox();
        ActiveRuleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
        DeleteRuleBtn = new Guna.UI2.WinForms.Guna2Button();
        SaveChangesBtn = new Guna.UI2.WinForms.Guna2Button();
        guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
        LogsLabel = new System.Windows.Forms.Label();
        guna2Panel1.SuspendLayout();
        guna2ShadowPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // guna2BorderlessForm1
        // 
        guna2BorderlessForm1.BorderRadius = 20;
        guna2BorderlessForm1.ContainerControl = this;
        guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
        guna2BorderlessForm1.TransparentWhileDrag = true;
        // 
        // CloseControlBtn
        // 
        CloseControlBtn.BorderColor = System.Drawing.Color.WhiteSmoke;
        CloseControlBtn.BorderRadius = 8;
        CloseControlBtn.CustomizableEdges = customizableEdges21;
        CloseControlBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        CloseControlBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        CloseControlBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)169)), ((int)((byte)169)));
        CloseControlBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)141)), ((int)((byte)141)), ((int)((byte)141)));
        CloseControlBtn.FillColor = System.Drawing.Color.RoyalBlue;
        CloseControlBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        CloseControlBtn.ForeColor = System.Drawing.Color.Black;
        CloseControlBtn.Location = new System.Drawing.Point(833, 3);
        CloseControlBtn.Name = "CloseControlBtn";
        CloseControlBtn.ShadowDecoration.CustomizableEdges = customizableEdges22;
        CloseControlBtn.Size = new System.Drawing.Size(37, 28);
        CloseControlBtn.TabIndex = 0;
        CloseControlBtn.Text = "X";
        CloseControlBtn.Click += CloseControlBtn_Click;
        // 
        // MinimizeControlBtn
        // 
        MinimizeControlBtn.BorderColor = System.Drawing.Color.WhiteSmoke;
        MinimizeControlBtn.BorderRadius = 8;
        MinimizeControlBtn.CustomizableEdges = customizableEdges19;
        MinimizeControlBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        MinimizeControlBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        MinimizeControlBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)169)), ((int)((byte)169)));
        MinimizeControlBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)141)), ((int)((byte)141)), ((int)((byte)141)));
        MinimizeControlBtn.FillColor = System.Drawing.Color.RoyalBlue;
        MinimizeControlBtn.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MinimizeControlBtn.ForeColor = System.Drawing.Color.Black;
        MinimizeControlBtn.Location = new System.Drawing.Point(791, 3);
        MinimizeControlBtn.Name = "MinimizeControlBtn";
        MinimizeControlBtn.ShadowDecoration.CustomizableEdges = customizableEdges20;
        MinimizeControlBtn.Size = new System.Drawing.Size(37, 28);
        MinimizeControlBtn.TabIndex = 1;
        MinimizeControlBtn.Text = "_";
        MinimizeControlBtn.Click += MinimizeControlBtn_Click;
        // 
        // ListProxyRules
        // 
        ListProxyRules.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)45)));
        ListProxyRules.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ListProxyRules.ForeColor = System.Drawing.SystemColors.Window;
        ListProxyRules.FormattingEnabled = true;
        ListProxyRules.Location = new System.Drawing.Point(0, 0);
        ListProxyRules.Name = "ListProxyRules";
        ListProxyRules.Size = new System.Drawing.Size(453, 424);
        ListProxyRules.TabIndex = 2;
        ListProxyRules.SelectedIndexChanged += ListProxyRules_SelectedIndexChanged;
        // 
        // guna2TextBox1
        // 
        guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
        guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)68)));
        guna2TextBox1.BorderRadius = 10;
        guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
        guna2TextBox1.CustomizableEdges = customizableEdges17;
        guna2TextBox1.DefaultText = "Proxy Rules - Create By Bimo";
        guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)208)), ((int)((byte)208)));
        guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)226)), ((int)((byte)226)));
        guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)68)));
        guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        guna2TextBox1.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        guna2TextBox1.Location = new System.Drawing.Point(14, 25);
        guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
        guna2TextBox1.Name = "guna2TextBox1";
        guna2TextBox1.PasswordChar = '\0';
        guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Transparent;
        guna2TextBox1.PlaceholderText = "";
        guna2TextBox1.SelectedText = "";
        guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges18;
        guna2TextBox1.Size = new System.Drawing.Size(770, 48);
        guna2TextBox1.TabIndex = 3;
        // 
        // guna2Panel1
        // 
        guna2Panel1.Controls.Add(label7);
        guna2Panel1.Controls.Add(NewResponseInput);
        guna2Panel1.Controls.Add(label6);
        guna2Panel1.Controls.Add(label5);
        guna2Panel1.Controls.Add(label4);
        guna2Panel1.Controls.Add(ProxySwitch);
        guna2Panel1.Controls.Add(UrlInput);
        guna2Panel1.Controls.Add(NameRuleInput);
        guna2Panel1.Controls.Add(label3);
        guna2Panel1.Controls.Add(label2);
        guna2Panel1.Controls.Add(label1);
        guna2Panel1.Controls.Add(MethodHttpSelect);
        guna2Panel1.Controls.Add(MatchTypeSelect);
        guna2Panel1.Controls.Add(ActiveRuleSwitch);
        guna2Panel1.Controls.Add(DeleteRuleBtn);
        guna2Panel1.Controls.Add(SaveChangesBtn);
        guna2Panel1.CustomizableEdges = customizableEdges15;
        guna2Panel1.Location = new System.Drawing.Point(506, 95);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
        guna2Panel1.Size = new System.Drawing.Size(349, 424);
        guna2Panel1.TabIndex = 4;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label7.Location = new System.Drawing.Point(24, 230);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(115, 20);
        label7.TabIndex = 15;
        label7.Text = "New Response:";
        // 
        // NewResponseInput
        // 
        NewResponseInput.AutoScroll = true;
        NewResponseInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        NewResponseInput.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        NewResponseInput.BorderRadius = 5;
        NewResponseInput.Cursor = System.Windows.Forms.Cursors.IBeam;
        NewResponseInput.CustomizableEdges = customizableEdges1;
        NewResponseInput.DefaultText = "";
        NewResponseInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)208)), ((int)((byte)208)));
        NewResponseInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)226)), ((int)((byte)226)));
        NewResponseInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        NewResponseInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        NewResponseInput.FillColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)68)));
        NewResponseInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        NewResponseInput.Font = new System.Drawing.Font("Segoe UI", 9F);
        NewResponseInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        NewResponseInput.Location = new System.Drawing.Point(25, 254);
        NewResponseInput.Multiline = true;
        NewResponseInput.Name = "NewResponseInput";
        NewResponseInput.PasswordChar = '\0';
        NewResponseInput.PlaceholderText = "";
        NewResponseInput.SelectedText = "";
        NewResponseInput.ShadowDecoration.CustomizableEdges = customizableEdges2;
        NewResponseInput.Size = new System.Drawing.Size(297, 76);
        NewResponseInput.TabIndex = 14;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label6.Location = new System.Drawing.Point(24, 104);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(99, 20);
        label6.TabIndex = 13;
        label6.Text = "URL:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label5.Location = new System.Drawing.Point(24, 32);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(99, 20);
        label5.TabIndex = 12;
        label5.Text = "Rule Name:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label4.Location = new System.Drawing.Point(173, 10);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(106, 20);
        label4.TabIndex = 11;
        label4.Text = "Active Proxy:";
        // 
        // ProxySwitch
        // 
        ProxySwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        ProxySwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        ProxySwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
        ProxySwitch.CheckedState.InnerColor = System.Drawing.Color.White;
        ProxySwitch.CustomizableEdges = customizableEdges3;
        ProxySwitch.Location = new System.Drawing.Point(285, 10);
        ProxySwitch.Name = "ProxySwitch";
        ProxySwitch.ShadowDecoration.CustomizableEdges = customizableEdges4;
        ProxySwitch.Size = new System.Drawing.Size(53, 23);
        ProxySwitch.TabIndex = 8;
        ProxySwitch.Text = "guna2ToggleSwitch1";
        ProxySwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)125)), ((int)((byte)137)), ((int)((byte)149)));
        ProxySwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)125)), ((int)((byte)137)), ((int)((byte)149)));
        ProxySwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
        ProxySwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
        ProxySwitch.CheckedChanged += ProxySwitch_CheckedChanged;
        // 
        // UrlInput
        // 
        UrlInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        UrlInput.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        UrlInput.BorderRadius = 5;
        UrlInput.Cursor = System.Windows.Forms.Cursors.IBeam;
        UrlInput.CustomizableEdges = customizableEdges5;
        UrlInput.DefaultText = "";
        UrlInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)208)), ((int)((byte)208)));
        UrlInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)226)), ((int)((byte)226)));
        UrlInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        UrlInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        UrlInput.FillColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)68)));
        UrlInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        UrlInput.Font = new System.Drawing.Font("Segoe UI", 9F);
        UrlInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        UrlInput.Location = new System.Drawing.Point(25, 128);
        UrlInput.Name = "UrlInput";
        UrlInput.PasswordChar = '\0';
        UrlInput.PlaceholderText = "";
        UrlInput.SelectedText = "";
        UrlInput.ShadowDecoration.CustomizableEdges = customizableEdges6;
        UrlInput.Size = new System.Drawing.Size(297, 36);
        UrlInput.TabIndex = 10;
        // 
        // NameRuleInput
        // 
        NameRuleInput.Animated = true;
        NameRuleInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        NameRuleInput.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        NameRuleInput.BorderRadius = 5;
        NameRuleInput.Cursor = System.Windows.Forms.Cursors.IBeam;
        NameRuleInput.CustomizableEdges = customizableEdges7;
        NameRuleInput.DefaultText = "";
        NameRuleInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)208)), ((int)((byte)208)));
        NameRuleInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)226)), ((int)((byte)226)));
        NameRuleInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        NameRuleInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)((byte)138)), ((int)((byte)138)), ((int)((byte)138)));
        NameRuleInput.FillColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)68)));
        NameRuleInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        NameRuleInput.Font = new System.Drawing.Font("Segoe UI", 9F);
        NameRuleInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        NameRuleInput.Location = new System.Drawing.Point(25, 56);
        NameRuleInput.Name = "NameRuleInput";
        NameRuleInput.PasswordChar = '\0';
        NameRuleInput.PlaceholderText = "";
        NameRuleInput.SelectedText = "";
        NameRuleInput.ShadowDecoration.CustomizableEdges = customizableEdges8;
        NameRuleInput.Size = new System.Drawing.Size(297, 36);
        NameRuleInput.TabIndex = 9;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label3.Location = new System.Drawing.Point(190, 180);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(115, 20);
        label3.TabIndex = 8;
        label3.Text = "Http Method:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(38, 181);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(88, 20);
        label2.TabIndex = 7;
        label2.Text = "Match Type:";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(87, 337);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(99, 20);
        label1.TabIndex = 6;
        label1.Text = "Active Rule:";
        // 
        // MethodHttpSelect
        // 
        MethodHttpSelect.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        MethodHttpSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        MethodHttpSelect.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        MethodHttpSelect.FormattingEnabled = true;
        MethodHttpSelect.Items.AddRange(new object[] { "GET", "POST" });
        MethodHttpSelect.Location = new System.Drawing.Point(190, 204);
        MethodHttpSelect.Name = "MethodHttpSelect";
        MethodHttpSelect.Size = new System.Drawing.Size(101, 23);
        MethodHttpSelect.TabIndex = 5;
        // 
        // MatchTypeSelect
        // 
        MatchTypeSelect.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)37)), ((int)((byte)51)));
        MatchTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        MatchTypeSelect.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        MatchTypeSelect.FormattingEnabled = true;
        MatchTypeSelect.Items.AddRange(new object[] { "Exact", "StartsWith", "EndsWith", "Contains" });
        MatchTypeSelect.Location = new System.Drawing.Point(38, 204);
        MatchTypeSelect.Name = "MatchTypeSelect";
        MatchTypeSelect.Size = new System.Drawing.Size(101, 23);
        MatchTypeSelect.TabIndex = 4;
        // 
        // ActiveRuleSwitch
        // 
        ActiveRuleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        ActiveRuleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)94)), ((int)((byte)148)), ((int)((byte)255)));
        ActiveRuleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
        ActiveRuleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
        ActiveRuleSwitch.CustomizableEdges = customizableEdges9;
        ActiveRuleSwitch.Location = new System.Drawing.Point(189, 336);
        ActiveRuleSwitch.Name = "ActiveRuleSwitch";
        ActiveRuleSwitch.ShadowDecoration.CustomizableEdges = customizableEdges10;
        ActiveRuleSwitch.Size = new System.Drawing.Size(53, 23);
        ActiveRuleSwitch.TabIndex = 2;
        ActiveRuleSwitch.Text = "guna2ToggleSwitch1";
        ActiveRuleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)125)), ((int)((byte)137)), ((int)((byte)149)));
        ActiveRuleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)125)), ((int)((byte)137)), ((int)((byte)149)));
        ActiveRuleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
        ActiveRuleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
        ActiveRuleSwitch.CheckedChanged += ActiveRuleSwitch_CheckedChanged;
        // 
        // DeleteRuleBtn
        // 
        DeleteRuleBtn.BorderRadius = 15;
        DeleteRuleBtn.CustomizableEdges = customizableEdges11;
        DeleteRuleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        DeleteRuleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        DeleteRuleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)169)), ((int)((byte)169)));
        DeleteRuleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)141)), ((int)((byte)141)), ((int)((byte)141)));
        DeleteRuleBtn.FillColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        DeleteRuleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
        DeleteRuleBtn.ForeColor = System.Drawing.Color.White;
        DeleteRuleBtn.Location = new System.Drawing.Point(186, 364);
        DeleteRuleBtn.Name = "DeleteRuleBtn";
        DeleteRuleBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
        DeleteRuleBtn.Size = new System.Drawing.Size(115, 44);
        DeleteRuleBtn.TabIndex = 1;
        DeleteRuleBtn.Text = "Delete Rule";
        DeleteRuleBtn.Click += DeleteRuleBtn_Click;
        // 
        // SaveChangesBtn
        // 
        SaveChangesBtn.BorderRadius = 15;
        SaveChangesBtn.CustomizableEdges = customizableEdges13;
        SaveChangesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        SaveChangesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        SaveChangesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)169)), ((int)((byte)169)));
        SaveChangesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)141)), ((int)((byte)141)), ((int)((byte)141)));
        SaveChangesBtn.FillColor = System.Drawing.Color.FromArgb(((int)((byte)124)), ((int)((byte)58)), ((int)((byte)237)));
        SaveChangesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
        SaveChangesBtn.ForeColor = System.Drawing.Color.White;
        SaveChangesBtn.Location = new System.Drawing.Point(49, 364);
        SaveChangesBtn.Name = "SaveChangesBtn";
        SaveChangesBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
        SaveChangesBtn.Size = new System.Drawing.Size(115, 44);
        SaveChangesBtn.TabIndex = 0;
        SaveChangesBtn.Text = "Save Changes";
        SaveChangesBtn.Click += SaveChangesBtn_Click;
        // 
        // guna2ShadowPanel1
        // 
        guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
        guna2ShadowPanel1.Controls.Add(ListProxyRules);
        guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
        guna2ShadowPanel1.Location = new System.Drawing.Point(26, 95);
        guna2ShadowPanel1.Name = "guna2ShadowPanel1";
        guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
        guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
        guna2ShadowPanel1.Size = new System.Drawing.Size(453, 424);
        guna2ShadowPanel1.TabIndex = 5;
        // 
        // LogsLabel
        // 
        LogsLabel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)51)), ((int)((byte)68)));
        LogsLabel.Font = new System.Drawing.Font("Ubuntu", 11.249998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LogsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        LogsLabel.Location = new System.Drawing.Point(252, 39);
        LogsLabel.Name = "LogsLabel";
        LogsLabel.Size = new System.Drawing.Size(516, 20);
        LogsLabel.TabIndex = 7;
        LogsLabel.Text = "Logs:";
        // 
        // ProxyRules
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)45)));
        ClientSize = new System.Drawing.Size(875, 565);
        Controls.Add(LogsLabel);
        Controls.Add(guna2ShadowPanel1);
        Controls.Add(guna2Panel1);
        Controls.Add(guna2TextBox1);
        Controls.Add(MinimizeControlBtn);
        Controls.Add(CloseControlBtn);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "ProxyRules";
        guna2Panel1.ResumeLayout(false);
        guna2ShadowPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Guna.UI2.WinForms.Guna2TextBox NewResponseInput;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label LogsLabel;

    private Guna.UI2.WinForms.Guna2TextBox UrlInput;

    private Guna.UI2.WinForms.Guna2TextBox NameRuleInput;

    private Guna.UI2.WinForms.Guna2ToggleSwitch ActiveRuleSwitch;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox MethodHttpSelect;

    private System.Windows.Forms.ComboBox MatchTypeSelect;

    private Guna.UI2.WinForms.Guna2ToggleSwitch ProxySwitch;

    private Guna.UI2.WinForms.Guna2Button SaveChangesBtn;

    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;

    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Guna.UI2.WinForms.Guna2Button DeleteRuleBtn;

    private System.Windows.Forms.ListBox ListProxyRules;
    private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

    private Guna.UI2.WinForms.Guna2Button CloseControlBtn;

    private Guna.UI2.WinForms.Guna2Button MinimizeControlBtn;

    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

    #endregion
}