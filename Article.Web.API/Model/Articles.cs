using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Article.Web.API.Model
{
    public class Articles : MongoBaseModel
    {
        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Url")]
        public string Url { get; set; }

        [BsonElement("InsertDate")]
        public DateTime InsertDate { get; set; }
    }
}
