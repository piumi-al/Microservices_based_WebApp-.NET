/* IT19207964
 * Weerasooriya K.T.N.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Data;
using UserService.Entites;

namespace Customer.Service.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 


        }

        public async Task<int> SaveUserChanges()
        {
            return await base.SaveChangesAsync();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

              modelBuilder.Entity<UserService.Entites.User>().HasData(

              new User()
              { Id=1 , FirstName = "Piumi", LastName = "Aluvihare" ,Contact = "0760563211", Address = "Matale", Email = "palu@gmail.com" },
              new User()
              { Id = 2 ,FirstName = "Mayangi" , LastName = "Dassanayake", Contact = "0762345661", Address = "Malabe", Email = "mayat@gmail.com" },
              new User()
              { Id = 3 ,FirstName = "Tharindu", LastName = "Weerasooriya",  Contact = "072345678", Address = "Kandy", Email = "thawe@gmail.com" });

        }

    }
}
