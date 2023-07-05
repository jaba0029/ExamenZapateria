using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria_Models;
using ZapateriaAPI.BussinessLayer.Services.Interfaces;
using ZapateriaAPI.DataAccessLayer.Repository.Interfaces;

namespace ZapateriaAPI.BussinessLayer.Services.Implementations
{
    public class ArticlesService : IArticlesService
    {
        private IArticlesRepository _articlesRepository;
        public ArticlesService(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }
        public async Task AddArticle(Articles articles)
        {
            await _articlesRepository.AddArticle(articles);
        }

        public async Task<IList<Articles>> ListArticles()
        {
            return await _articlesRepository.ListArticles();
        }

        public async Task<Articles> ListArticlesByStore(int id)
        {
            return await _articlesRepository.ListArticlesByStore(id);
        }
    }
}
