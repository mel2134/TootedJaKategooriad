using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=products.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Toit" },
                new Category { CategoryId = 2, CategoryName = "Rehvid" },
                new Category { CategoryId = 3, CategoryName = "Arvutid" },
                new Category { CategoryId = 4, CategoryName = "Telefonid" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Piim"},
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Kanaliha" },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Kurk" },
                new Product { ProductId = 4, CategoryId = 1, ProductName = "Peet" },
                new Product { ProductId = 5, CategoryId = 1, ProductName = "Keefir" },
                new Product { ProductId = 6, CategoryId = 1, ProductName = "Hapukoor" },
                new Product { ProductId = 7, CategoryId = 1, ProductName = "Makaronid" },
                new Product { ProductId = 8, CategoryId = 1, ProductName = "Kartul" },
                new Product { ProductId = 9, CategoryId = 1, ProductName = "Kapsas" },
                new Product { ProductId = 10, CategoryId = 1, ProductName = "Banaan" },
                new Product { ProductId = 11, CategoryId = 1, ProductName = "Arbuus" },
                new Product { ProductId = 12, CategoryId = 1, ProductName = "Melon" },
                new Product { ProductId = 13, CategoryId = 1, ProductName = "Veiseliha" },

                new Product { ProductId = 14, CategoryId = 2, ProductName = "Suverehvid" },
                new Product { ProductId = 15, CategoryId = 2, ProductName = "Naastrehvid" },
                new Product { ProductId = 16, CategoryId = 2, ProductName = "Lamellid" },

                new Product { ProductId = 17, CategoryId = 3, ProductName = "Vivobook Go 14" },
                new Product { ProductId = 18, CategoryId = 3, ProductName = "Vivobook Pro 15" },
                new Product { ProductId = 19, CategoryId = 3, ProductName = "Vivobook Go 16" },
                new Product { ProductId = 20, CategoryId = 3, ProductName = "Vivobook Pro 17" },
                new Product { ProductId = 21, CategoryId = 3, ProductName = "Vivobook Go 18" },
                new Product { ProductId = 22, CategoryId = 3, ProductName = "Vivobook Go 19" },
                new Product { ProductId = 23, CategoryId = 3, ProductName = "Vivobook Pro 20" },
                new Product { ProductId = 24, CategoryId = 3, ProductName = "Vivobook Go 21" },
                
                new Product { ProductId = 25, CategoryId = 4, ProductName = "IPhone 6" },
                new Product { ProductId = 26, CategoryId = 4, ProductName = "IPhone 7" },
                new Product { ProductId = 27, CategoryId = 4, ProductName = "IPhone 8" },
                new Product { ProductId = 28, CategoryId = 4, ProductName = "IPhone 9" },
                new Product { ProductId = 29, CategoryId = 4, ProductName = "IPhone 10" },
                new Product { ProductId = 30, CategoryId = 4, ProductName = "IPhone 11" },
                new Product { ProductId = 31, CategoryId = 4, ProductName = "IPhone 12" },
                new Product { ProductId = 32, CategoryId = 4, ProductName = "IPhone 13" },
                new Product { ProductId = 33, CategoryId = 4, ProductName = "IPhone 14" }
                );
        }
    }
}
