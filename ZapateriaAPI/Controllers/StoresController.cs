using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Zapateria_Models;
using ZapateriaAPI.BussinessLayer.Services.Interfaces;

namespace ZapateriaAPI.Controllers
{
    [RoutePrefix("v1")]
    public class StoresController : BaseController
    {
        IStoreService _storeService;

        public StoresController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> ListStores()
        {
            return Ok(await _storeService.ListStores());
        }
     
        [HttpPost]
        [Route("api/Stores")]
        public async Task<IHttpActionResult> AddStore(Stores stores)
        {
            await _storeService.AddStore(stores);
            return Ok(HttpStatusCode.OK);
        }
     }
}
