using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZapateriaAPI.Models.Request
{
    public class Articulo
    {
		public int  id { get; set; }
        public string Name {get; set; }
		public string Description { get; set; }
		public decimal price { get; set; }
		public int total_in_shelf { get; set; }
		public int total_in_vault { get; set; }
		public int store_id { get; set; }
	}
}