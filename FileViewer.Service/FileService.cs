using FileViewer.Model;
using FileViewer.Service.DBConnection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer.Service
{
    public class FileService
    {

        private readonly IMongoCollection<StoredFile> _files;

        public FileService(IFileStorageDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _files = database.GetCollection<StoredFile>(settings.CollectionName);
        }

        public async Task<List<StoredFile>> GetAllAsync()
        {
            return await _files.Find(f => true).ToListAsync();
        }
        public async Task PutAsync(StoredFile storedFile)
        {
            await _files.InsertOneAsync(storedFile);
        }
    }
}
