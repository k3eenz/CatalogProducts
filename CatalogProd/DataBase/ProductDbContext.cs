using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProd.DataBase
{
    internal class ProductDbContext : DbContext
    {
        internal DbSet<Users> Users { get; set; }
        internal DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = \\\\iscsi\\profstud\\OsipenkoMD\\Desktop\\Новая папка (4)\\CatalogProd\\DataBase\\ProductCatalog.db");
        }
    }
}
