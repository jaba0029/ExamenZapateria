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
    public class StoreRepository : IStoreRepository
    {
        private ShopContext _Context;
        public StoreRepository(ShopContext Context)
        {
            _Context = Context;
        }

        public async Task<IList<Stores>> ListStores()
        {
            return await _Context.stores.ToListAsync();
        }

        public async Task AddStore(Stores stores)
        {
            _Context.stores.Add(stores);
            await _Context.SaveChangesAsync();
        }
    }
}
