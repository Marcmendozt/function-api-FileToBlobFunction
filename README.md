# LogicToBlob - Azure Function

Este proyecto es una **Azure Function** desarrollada en .NET 8 que recibe archivos enviados por una **Logic App**, procesa la información y almacena el contenido en **Azure Blob Storage**.

## Características
- Recepción de archivos vía HTTP Trigger.
- Integración con Azure Blob Storage para almacenamiento seguro.
- Arquitectura por capas: Domain, Application, Infrastructure.
- Logging y monitoreo con Application Insights.
- Listo para CI/CD con GitHub Actions o Azure DevOps.

## Flujo
1. La Logic App envía una solicitud HTTP a la Azure Function con el archivo y metadatos.
2. La Azure Function procesa y valida la información.
3. El archivo se guarda en el contenedor configurado de Azure Blob Storage.
4. Se registran métricas y logs en Application Insights.

## Requisitos
- Azure Storage Account.
- Azure Function App.
- .NET 8 SDK.
- Visual Studio 2022 o superior.

## Despliegue
Puede desplegarse mediante:
- **Publicación directa desde Visual Studio**.
- **GitHub Actions** conectado al repositorio.
- **Azure DevOps Pipelines**.

## Licencia
MIT License.
