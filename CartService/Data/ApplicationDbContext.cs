/* IT19152110
 * Rajapaksha K.D.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Entities;

namespace CartService.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Cart> Carts{ get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 


        }

        public async Task<int> SaveCartChanges()
        {
            return await base.SaveChangesAsync();
        }


       protected override void OnModelCreating(ModelBuilder modelBuilder) 
          {

                modelBuilder.Entity<Cart>().HasData(

                new Cart()
                { Id = 1, ProductId = 2, Addede_Date = "12-05-2022", Quantity = 4 , sub_total = 1200 },
                new Cart()
                { Id = 2, ProductId = 3, Addede_Date = "11-06-2022", Quantity = 5 , sub_total = 1400},
                new Cart()
                { Id = 3, ProductId = 4, Addede_Date = "12-06-2022", Quantity = 2  , sub_total= 1300});

         }

    }
}
