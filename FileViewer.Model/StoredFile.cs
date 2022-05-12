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
        public int Size { get; set; } = 0;

        [BsonElement("data")]
        public string Data { get; set; } = "";

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("isDeleted")]
        public bool IsDeleted { get; set; }
    }
}
