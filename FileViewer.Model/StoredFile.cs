using MongoDB.Bson.Serialization.Attributes;

namespace FileViewer.Model
{
    public record StoredFile
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; } = "";

        [BsonElement("contentType")]
        public string ContentType { get; set; } = "";

        [BsonElement("size")]
        public string Size { get; set; } = "";

        [BsonElement("data")]
        public byte[] Data { get; set; } = new byte[] { };

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("isDeleted")]
        public bool IsDeleted { get; set; }
    }
}
