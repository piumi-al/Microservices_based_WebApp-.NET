/* IT19207964
 * Weerasooriya K.T.N.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Data;
using DeliveryService.Entities;


namespace DeliveryService.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Delivery> Deliveries { get; set; }
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 


        }

        public async Task<int> SaveDeliveryChanges()
        {
            return await base.SaveChangesAsync();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<Delivery>().HasData(

            new Delivery()
            { Id = 1, OrderID = 3, Delivery_ProductName = "Hanging Wall Art", Delivery_Contact = "0765645123", Delivery_location = "Matale", Delivery_charge = 250 },
            new Delivery()
            { Id = 2, OrderID = 4, Delivery_ProductName = "Painting Decoration Wall Art", Delivery_Contact = "0765645444", Delivery_location = "Kandy", Delivery_charge = 300 });

        }

    }
}
