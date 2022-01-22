23 - Proveedores de Configuracion

Para cambiar de desarrrollo a produccion podemos cambiar en el archivo que se encuentra en la
carpeta Properties el archivo  launchSettings.json

"profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },

    cambiamos por:

"profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Production"
      }
    },




