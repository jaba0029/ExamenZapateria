using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria_Models;
using ZapateriaAPI.DataAccessLayer.Repository.Interfaces;

namespace ZapateriaAPI.DataAccessLayer.Repository.Implementations
{
    public class ArticlesRepository : IArticlesRepository
    {
        private ShopContext _Context;
        public ArticlesRepository(ShopContext Context)
        {
            _Context = Context;
        }

        public async Task<IList<Articles>> ListArticles()
        {
            return await _Context.articles.ToListAsync();
        }

        public async Task<Articles> ListArticlesByStore(int id)
        {
            return await _Context.articles.FindAsync(id);
        }

        public async Task AddArticle(Articles articles)
        {
            _Context.articles.Add(articles);
            await _Context.SaveChangesAsync();
        }

    }
}
