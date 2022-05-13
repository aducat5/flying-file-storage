using FileViewer.Service;
using FileViewer.Web.Api.Controllers;
using FileViewer.Web.Api.Tests;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer.Test
{
    public class FileControllerTest
    {

        private FileController _fileController;

        [SetUp]
        public void Setup()
        {
            var settings = Util.GetDBSettings();
            var service = new FileService(settings);
            _fileController = new FileController(service);
        }

        [Test]
        public async Task GetAllTestAsync()
        {
            var files = await _fileController.GetAll();
            Assert.IsNotNull(files);
        }

        [Test]
        public async Task UploadValidFileTestAsync()
        {
            var result = await _fileController.UploadFiles(new() { type="image/png" });
            Assert.IsInstanceOf<OkResult>(result);
        }

        [Test]
        public async Task UploadInvalidFileTestAsync()
        {
            var result = await _fileController.UploadFiles(new() { type="invalid/type" });
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
        }
    }
}
