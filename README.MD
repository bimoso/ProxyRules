[English](https://github.com/bimoso/ProxyRules/blob/main/README-US.md)
# Proxy Rules Manager 🚀

Aplicación sencilla para administrar reglas de proxy, permitiendo agregar, editar, eliminar y guardar configuraciones de manera rápida.

## Características ✨
- Agregar nuevas reglas
- Editar reglas existentes
- Eliminar reglas
- Habilitar o deshabilitar reglas
- Guardar y cargar reglas desde un archivo JSON
- Iniciar y detener el proceso proxy

## Dependencies 📦
- .NET 8 última versión
- .NET 9 última versión
- Newtonsoft.Json

## Instalación 🛠️
1. Clona el repositorio:
    ```bash
    git clone https://github.com/bimoso/ProxyRules.git
    ```
2. Abre la solución en Visual Studio o tu IDE preferido.
3. Restaura los paquetes NuGet.

## Uso 🚀
1. Ejecuta la aplicación.
2. Administra reglas de proxy:
   - **Agregar**: Completa los campos y haz clic en "Save Changes".
   - **Editar**: Modifica la regla seleccionada y haz clic en "Save Changes".
   - **Eliminar**: Selecciona una regla y haz clic en "Delete Rule".
   - **Habilitar/Deshabilitar**: Alterna el interruptor de la regla.
3. Las reglas se almacenan en el archivo `proxy_rules.json`.

## Formato JSON 📄
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