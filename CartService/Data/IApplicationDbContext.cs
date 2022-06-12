/* IT19152110
 * Rajapaksha K.D.
 */
using Microsoft.EntityFrameworkCore;
using CartService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartService.Data
{
    public interface IApplicationDbContext
    {
       
        DbSet<Cart> Carts{ get; set; }
        

        Task<int> SaveCartChanges();
       

    }
}
