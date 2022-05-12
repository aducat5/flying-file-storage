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

        [HttpPost("upload")]
        public async Task<ActionResult> UploadFiles(StoredFile file)
        {
            //make your checks
            try
            {
                bool isUploaded = await _fileService.PutAsync(file);
                return Ok(isUploaded);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}