/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountService.Data;
using DiscountService.Entities;

namespace DiscountService.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Discount> Discounts { get; set; }
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 


        }

        public async Task<int> SaveDiscountChanges()
        {
            return await base.SaveChangesAsync();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<Discount>().HasData(

            new Discount()
            { Id = 1, productID = 3 , Discount_Type = "fixed", Discount_amount = 100, start_date = "05-06-2022", end_date = "05-07-2022" },
            new Discount()
            { Id = 2, productID = 4, Discount_Type = "%", Discount_amount = 10, start_date = "15-06-2022", end_date = "15-07-2022" });

        }
       

    }
}
