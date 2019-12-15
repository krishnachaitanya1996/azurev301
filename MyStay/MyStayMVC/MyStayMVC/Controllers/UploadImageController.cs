using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage.Blob;
using MyStayMVC.Models;
using MyStayMVC.Utility;

namespace MyStayMVC.Controllers
{
    public class UploadImageController : Controller
    {
        //Dependency Injection on IOptions<TOptions> to access the settings. 
        //This is stored as a member variable which can be used throughout the controller for ease of access
        private readonly IOptions<StorageAccountOptions> _optionsAccessor;
        private readonly BlobUtility _blobUtility;
        public UploadImageController(IOptions<StorageAccountOptions> optionsAccessor)
        {
            _optionsAccessor = optionsAccessor;
            _blobUtility = new BlobUtility(_optionsAccessor.Value.StorageAccountNameOption, _optionsAccessor.Value.StorageAccountKeyOption);
        }

        public async Task<ActionResult> UploadImage()
        {
            List<IListBlobItem> blobItems = await _blobUtility.GetBlobs(_optionsAccessor.Value.BlobContainer);
            return View(blobItems);
        }
        [HttpPost]
        public async Task<ActionResult> SubmitImage(IFormFile files)
        {

            await _blobUtility.UploadBlob(_optionsAccessor.Value.BlobContainer, files);

            return RedirectToAction("UploadImage");
        }


    }
}