using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria_Models;

namespace ZapateriaAPI.DataAccessLayer.Repository.Interfaces
{
    public interface IArticlesRepository
    {
        Task<IList<Articles>> ListArticles();
        Task<Articles> ListArticlesByStore(int id);
        Task AddArticle(Articles articles);
    }
}
