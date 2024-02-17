using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace File.Application;

[Route("api/[controller]")]
[ApiController]
public class FileProcessingController : ControllerBase, IFileProcessingController
{
    [HttpPost("upload")]
    [Consumes("multipart/form-data")]
    public IActionResult UploadFile(IFormFile file)
    {
        // Обработка загруженного файла здесь
        // Возможно, сохранение файла на сервере или в базе данных
        return Ok("File uploaded successfully");
    }


    [HttpGet("download/{id}")]
    [Produces("text/plain")]

    public IActionResult DownloadFile([FromRoute] long id)
    {

        var content = "This is a placeholder text file.";

        // Конвертация содержимого файла в байты
        var fileBytes = Encoding.UTF8.GetBytes(content);

        // Установка имени файла
        var fileName = "placeholder.txt";

        return File(fileBytes, "text/plain", fileName);
    }
}
