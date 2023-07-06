using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaCommon.DTOs;
using ZapateriaPresentacion.Services.Interface;


namespace ZapateriaPresentacion.Services.Implement
{
    public class StoreService : IStoreService
    {
        public Task<IList<Store>> SaveStore(Store objStore)
        {
            var result = Client.Client.Instance.PostAsync<List<Store>>(objStore,$"v1/api/Stores");
            return Task.FromResult<IList<Store>>(result);
        }

        public Task<IList<Store>> GetStore()
        {
            var result = Client.Client.Instance.GetAsync<List<Store>>($"api/Stores");
            return Task.FromResult<IList<Store>>(result);
        }
    }
}
