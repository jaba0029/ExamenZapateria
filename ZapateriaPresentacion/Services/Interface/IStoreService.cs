using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaCommon.DTOs;

namespace ZapateriaPresentacion.Services.Interface
{
    public interface IStoreService
    {
        Task<IList<Store>> SaveStore(Store objStore);
        Task<IList<Store>> GetStore();
    }
}
