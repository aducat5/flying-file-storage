using FileViewer.Service;
using FileViewer.Web.Api.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer.Test
{
    public class FileServiceTest
    {

        private FileService _service;

        [SetUp]
        public void Setup()
        {
            var settings = Util.GetDBSettings();
            _service = new FileService(settings);
        }

        [Test]
        public async Task GetAllTestAsync()
        {
            var files = await _service.GetAllAsync();
            Assert.IsNotNull(files);
        }

        [Test]
        public void PutFileTestAsync()
        {
            Assert.DoesNotThrowAsync(async () => await _service.PutAsync(new() { name="testfile" }));
        }
    }
}
