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
    public class StoreService : IStoreService
    {
        private IStoreRepository _storeRepository;
        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task AddStore(Stores stores)
        {
            await _storeRepository.AddStore(stores);
        }

        public async Task<IList<Stores>> ListStores()
        {
            return await _storeRepository.ListStores();
        }
    }
}
