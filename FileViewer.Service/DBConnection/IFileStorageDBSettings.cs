namespace FileViewer.Service.DBConnection
{
    public interface IFileStorageDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}