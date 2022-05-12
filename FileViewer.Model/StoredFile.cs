using MongoDB.Bson.Serialization.Attributes;

namespace FileViewer.Model
{
    public record StoredFile
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; } = "";

        [BsonElement("type")]
        public string Type { get; set; } = "";

        [BsonElement("size")]
        public string Size { get; set; } = "";

        [BsonElement("data")]
        public byte[] Data { get; set; } = Array.Empty<byte>();

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("isDeleted")]
        public bool IsDeleted { get; set; }
    }
}
