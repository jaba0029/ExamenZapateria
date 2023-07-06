using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaCommon.DTOs
{
    public class Articles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int TotalShelf { get; set; }
        public int TotalVault { get; set; }
        public int StoreId { get; set; }

    }
}
