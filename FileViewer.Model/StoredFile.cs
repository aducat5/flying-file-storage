using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FileViewer.Model
{
    public record StoredFile
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("name")]
        public string name { get; set; } = "";

        [BsonElement("type")]
        public string type { get; set; } = "";

        [BsonElement("size")]
        public int size { get; set; } = 0;

        [BsonElement("data")]
        public string data { get; set; } = "";

        [BsonElement("createdAt")]
        public DateTime createdAt { get; set; }

        [BsonElement("isDeleted")]
        public bool isDeleted { get; set; }
    }
}
