using FileViewer.Service.DBConnection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer.Web.Api.Tests
{
    public static class Util
    {
        private static FileStorageDBSettings? _settings;

        public static FileStorageDBSettings GetDBSettings()
        {
            if (_settings != null) return _settings;

            _settings = new FileStorageDBSettings()
            {
                ConnectionString = "mongodb+srv://cognizant-user:TestUser123--@sandbox.mm9lf.mongodb.net/fileStorage?retryWrites=true&w=majority",
                DatabaseName = "fileStorage",
                CollectionName = "files"
            };

            return _settings;
        }
    }
}
