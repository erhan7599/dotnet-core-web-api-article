using Article.Web.API.Model;

namespace Article.Web.API.Services.MongoRepository
{
    public class ArticlesRepository : BaseMongoRepository<Articles>
    {
        public ArticlesRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
