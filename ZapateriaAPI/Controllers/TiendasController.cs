using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZapateriaAPI.Controllers
{
    public class TiendasController : ApiController
    {

        [HttpGet]
        public IEnumerable<Models.stores> ListarTiendas()
        {
            IEnumerable<Models.stores> listaTiendas;
            using (Models.ZapateriaEntities db = new Models.ZapateriaEntities())
            {
                listaTiendas = db.stores.ToList();
            }
            return listaTiendas;
        }


     
        [HttpPost]
        public IHttpActionResult Agregar(Models.Request.Tienda model)
        {
            using (Models.ZapateriaEntities db = new Models.ZapateriaEntities())
            {
                var oTienda = new Models.stores();
                oTienda.name = model.Name;
                oTienda.address = model.Address;
                db.stores.Add(oTienda);
                db.SaveChanges();
            }
            return Ok("éxito");
        }

     }
}
