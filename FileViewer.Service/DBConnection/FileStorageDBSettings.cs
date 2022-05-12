namespace FileViewer.Service.DBConnection
{
    public record FileStorageDBSettings : IFileStorageDBSettings
    {
        public string CollectionName { get; set; } = "";
        public string ConnectionString { get; set; } = "";
        public string DatabaseName { get; set; } = "";
    }
}
