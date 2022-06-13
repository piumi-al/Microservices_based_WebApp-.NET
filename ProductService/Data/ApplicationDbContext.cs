/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Data;
using ProductService.Entities;

namespace ProductService.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 


        }

        public async Task<int> SaveProductChanges()
        {
            return await base.SaveChangesAsync();
        }


         protected override void OnModelCreating(ModelBuilder modelBuilder) 
          {

                modelBuilder.Entity<Product>().HasData(

                new Product()
                { Id = 1 , Product_Name = "Hanging Wall Art", Code = "P001" , Quantity_In_Stock = 50, Unit_Price = 1500 },
                new Product()
                { Id = 2, Product_Name = "Painting Decoration Wall Art", Code = "P002", Quantity_In_Stock = 25, Unit_Price = 2000},
                new Product()
                { Id = 3, Product_Name = "Indoor Wall Plants", Code = "P003", Quantity_In_Stock = 30, Unit_Price = 890 });

         }

    }
}
