using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioBlogWebApp.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            string webRootPath = _webHostEnvironment.WebRootPath; 

            long size = files.Sum(f => f.Length); //number of files uploaded

            var filePaths = new List<string>();

            foreach(var formFile in files)
            {
                if(formFile.Length > 0)
                {
                    //Set the Image File Path.
                    var filePath = Path.Combine(webRootPath + "\\images\\", formFile.FileName);
                    
                    //Add Image File Path to List.
                    filePaths.Add(filePath);

                    //Save the Image File in Folder.
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    //TODO: Save changes to database

                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePaths });
        }
    }
}