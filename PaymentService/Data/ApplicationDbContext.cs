/* IT19152110
 * Rajapaksha K.D.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Data;
using PaymentService.Entities;

namespace PaymentService.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Payment> Payments { get; set; }
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 


        }

        public async Task<int> SavePaymentChanges()
        {
            return await base.SaveChangesAsync();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<Payment>().HasData(

            new Payment()
            { Id = 1, CardNo = "1234 1234 1234 1234", Name_On_Card = "D.S.Perera", Expire_Date = "12-05-2024", CVC = 167, Total_Amount = 4000 },
            new Payment()
            { Id = 2, CardNo = "1234 1234 1234 1234", Name_On_Card = "D.S.Perera", Expire_Date = "12-05-2024", CVC = 167, Total_Amount = 4000 });
            
    }

    }
}
