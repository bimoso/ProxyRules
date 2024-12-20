# Proxy Rules Manager 🚀

Simple application to manage proxy rules, allowing you to add, edit, delete, and save configurations quickly.

## Features ✨
- Add new rules
- Edit existing rules
- Delete rules
- Enable or disable rules
- Save and load rules from a JSON file
- Start and stop the proxy process

## Dependencies 📦
- .NET 8 latest version
- .NET 9 latest version
- Newtonsoft.Json

## Installation 🛠️
1. Clone the repository:
    ```bash
    git clone https://github.com/bimoso/ProxyRules.git
    ```
2. Open the solution in Visual Studio or your preferred IDE.
3. Restore the NuGet packages.

## Usage 🚀
1. Run the application.
2. Manage proxy rules:
   - **Add**: Fill in the fields and click "Save Changes".
   - **Edit**: Modify the selected rule and click "Save Changes".
   - **Delete**: Select a rule and click "Delete Rule".
   - **Enable/Disable**: Toggle the rule switch.
3. The rules are stored in the `proxy_rules.json` file.

## JSON Format 📄
```json
{
  "rules": [
    {
      "Name": "zorara",
      "HostPattern": "getzorara.online:5000",
      "UrlPattern": "/check_key",
      "MatchType": "Exact",
      "HttpMethod": "GET",
      "Response": {
        "message": "Key is valid."
      },
      "IsEnabled": true
    }
  ]
}
```
