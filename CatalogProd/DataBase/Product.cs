using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProd.DataBase
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int PhotoID { get; set; } = -1;
    }
}
