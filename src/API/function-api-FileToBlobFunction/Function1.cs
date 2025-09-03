using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace function_api_FileToBlobFunction
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request. nuevo logs asasas");

            // Leer el archivo subido y obtener el tamaño
            long fileSize = 0;
            string fileName = "";
            if (req.Form.Files.Count > 0)
            {
                var file = req.Form.Files[0];
                fileSize = file.Length;
                fileName = file.FileName;
                _logger.LogInformation($"Archivo recibido: {fileName}, tamaño: {fileSize} bytes");
            }
            else
            {
                _logger.LogWarning("No se recibió ningún archivo en la petición.");
            }

            // Log al final del procesamiento
            _logger.LogInformation("Archivo procesado correctamente (Excel o PDF)");
            return new OkObjectResult($"Welcome to Azure Functions! Tamaño del archivo: {fileSize} bytes");
        }
    }
}
