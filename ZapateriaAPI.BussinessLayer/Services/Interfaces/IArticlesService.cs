using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria_Models;

namespace ZapateriaAPI.BussinessLayer.Services.Interfaces
{
    public interface IArticlesService
    {
        Task<IList<Articles>> ListArticles();
        Task<Articles> ListArticlesByStore(int id);
        Task AddArticle(Articles articles);
    }
}
