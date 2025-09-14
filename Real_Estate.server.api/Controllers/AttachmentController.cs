using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Real_Estate.server.api.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]  
    public class AttachmentController :  ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public AttachmentController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [Route("get/{filename}")]
        public async Task<IActionResult> GetImage(string filename)
        {
            string Rootpath = webHostEnvironment.ContentRootPath;
            string fileUploadRoot = Rootpath + "/assets/images";
            string FilePath = Path.Combine(fileUploadRoot, filename);

            if (!System.IO.File.Exists(FilePath))
            {
                return NotFound();
            }

            MemoryStream memory = new MemoryStream();
            using (FileStream stream = new FileStream(FilePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "image/png", Path.GetFileName(FilePath));
        }
    }
}
