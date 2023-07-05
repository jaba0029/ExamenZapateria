using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria_Models;

namespace ZapateriaAPI.BussinessLayer.Services.Interfaces
{
    public interface IStoreService
    {
        Task<IList<Stores>> ListStores();
        Task AddStore(Stores stores);
    }
}
