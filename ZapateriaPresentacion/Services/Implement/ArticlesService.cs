using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaCommon.DTOs;
using ZapateriaPresentacion.Services.Interface;

namespace ZapateriaPresentacion.Services.Implement
{
    public class ArticlesService : IArticlesService
    {
        public Task<Articles> SaveArticle(Articles objArticle)
        {
            var result = Client.Client.Instance.PostAsync<Articles>(objArticle, $"v1/api/Articles");
            return Task.FromResult<Articles>(result);
        }

        public Task<IList<Articles>> GetArticle()
        {
            var result = Client.Client.Instance.GetAsync<List<Articles>>($"api/Articles");
            return Task.FromResult<IList<Articles>>(result);
        }

        public Task<Articles> GetArticlexId(int id)
        {
            var result = Client.Client.Instance.GetAsync<Articles>($"api/Articles/{id}");
            return Task.FromResult<Articles>(result);
        }
    }
}
