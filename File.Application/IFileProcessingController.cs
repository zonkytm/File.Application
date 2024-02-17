using Microsoft.AspNetCore.Mvc;

namespace File.Application;

/// <summary>
/// Интерфейс для обработки файлов.
/// </summary>
public interface IFileProcessingController
{
    /// <summary>
    /// метод для загрузки файла из бд.
    /// </summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <returns>Возвращает файл.</returns>
    IActionResult DownloadFile([FromRoute] long id);

    /// <summary>
    /// Метод для загрузки файла в бд.
    /// </summary>
    /// <param name="file">Загруженный файл.</param>
    /// <returns>Возвращает сообщение о успешной загруки файла.</returns>
    IActionResult UploadFile(IFormFile file);
}