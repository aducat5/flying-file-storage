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
            var groupedFiles = storedFiles.GroupBy(f => f.type).Select(grp => grp.ToList()).ToList();
            return Ok(groupedFiles);
        }

        [HttpPost("upload")]
        public async Task<ActionResult> UploadFiles(StoredFile file)
        {
            var allowedTypes = new List<string>()
            {
                "image/jpeg",
                "image/png",
                "application/pdf"
            };
            //make your checks
            try
            {
                if (!allowedTypes.Contains(file.type))
                    return BadRequest("type of file is not allowed.");
                    
                file.createdAt = DateTime.Now;
                await _fileService.PutAsync(file);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}