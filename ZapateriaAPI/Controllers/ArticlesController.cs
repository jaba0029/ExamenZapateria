using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Zapateria_Models;
using ZapateriaAPI.BussinessLayer.Services.Interfaces;

namespace ZapateriaAPI.Controllers
{
    public class ArticlesController : ApiController
    {
        IArticlesService _articlesService;
        public ArticlesController(IArticlesService articlesService)
        {
            _articlesService = articlesService;
        }

        [Route("api/Articles")]
        [HttpGet]
        public async Task<IHttpActionResult> ListArticles()
        {
            return Ok(await _articlesService.ListArticles());
        }

        [Route("api/Articles/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> ListArticlesByStore(string id)
        {
            return Ok(HttpStatusCode.OK);
        }

        [Route("api/Articles")]
        [HttpPost]
        public async Task<IHttpActionResult> AddArticle(Articles articles)
        {
            await _articlesService.AddArticle(articles);
            return Ok(HttpStatusCode.OK);
        }
    }
}
