using MongoDB.Bson;

namespace Article.Web.API.Model
{
    public abstract class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}
