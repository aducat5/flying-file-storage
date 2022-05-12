using FileViewer.Model;
using FileViewer.Service;
using Microsoft.AspNetCore.Mvc;

namespace FileViewer.Web.Api.Controllers
{
    [ApiController]
    [Route("file")]
    public class FileController : ControllerBase
    {
        private readonly FileService _fileService;

        public FileController(FileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<StoredFile>>> GetAll()
        {
            var storedFiles = await _fileService.GetAllAsync();
            return Ok(storedFiles);
        }

        [HttpGet("upload")]
        public async Task<ActionResult<IEnumerable<StoredFile>>> UploadFile(StoredFile file)
        {
            //make your checks
            bool isUploaded = await _fileService.PutAsync(file);
            if (isUploaded)
                return Ok();
            else
                return BadRequest();
        }
    }
}