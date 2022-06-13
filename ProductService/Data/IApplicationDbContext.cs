/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using Microsoft.EntityFrameworkCore;
using ProductService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Data
{
    public interface IApplicationDbContext
    {
       
        DbSet<Product> Products{ get; set; }
        

        Task<int> SaveProductChanges();
       

    }
}
