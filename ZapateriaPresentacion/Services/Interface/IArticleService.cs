using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaCommon.DTOs;

namespace ZapateriaPresentacion.Services.Interface
{
    public interface IArticleService
    {
        Task<Articles> SaveArticle(Articles objArticle);
        Task<IList<Articles>> GetArticle();
        Task<Articles> GetArticlexId(int id);
    }
}
