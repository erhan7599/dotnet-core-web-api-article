using Article.Web.API.Model;
using Article.Web.API.Services.MongoRepository;
using Microsoft.AspNetCore.Mvc;

namespace Article.Web.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ArticlesController : BaseMongoController<Articles>
    {

        public ArticlesController(ArticlesRepository articlesRepository) : base(articlesRepository)
        {
        }
    }
}