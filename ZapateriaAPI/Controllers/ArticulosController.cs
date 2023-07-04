using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZapateriaAPI.Controllers
{
    public class ArticulosController : ApiController
    {
        [HttpGet]
        public IEnumerable<Models.articles> ListarArticulos()
        {
            IEnumerable<Models.articles> listaArticulos;
            using (Models.ZapateriaEntities db = new Models.ZapateriaEntities())
            {
                listaArticulos = db.articles.ToList();
            }
            return listaArticulos;
        }

        [HttpGet]
        public IEnumerable<Models.articles> ListarArticulosXTienda(string stored_id)
        {
            IEnumerable<Models.articles> listaArticulos;
            IEnumerable<Models.articles> listaArticulosxTienda;
            using (Models.ZapateriaEntities db = new Models.ZapateriaEntities())
            {
                listaArticulos = db.articles.ToList();
                listaArticulosxTienda = listaArticulos.Where(x => x.store_id == int.Parse(stored_id));
            }
            return listaArticulosxTienda;
        }


        [HttpPost]
        public IHttpActionResult Agregar(Models.Request.Articulo model)
        {
            using (Models.ZapateriaEntities db = new Models.ZapateriaEntities())
            {
                var oArticulo = new Models.articles();
                oArticulo.name = model.Name;
                oArticulo.description = model.Description;             
                oArticulo.price = model.price;
                oArticulo.total_in_shelf = model.total_in_shelf;
                oArticulo.total_in_vault = model.total_in_vault;
                oArticulo.store_id = model.store_id;
                db.articles.Add(oArticulo);
                db.SaveChanges();
            }
            return Ok("éxito");
        }
    }
}
