using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria_Models;

namespace ZapateriaAPI.DataAccessLayer.Repository.Interfaces
{
    public interface IStoreRepository
    {
        Task<IList<Stores>> ListStores();
        Task AddStore(Stores stores);
    }
}
