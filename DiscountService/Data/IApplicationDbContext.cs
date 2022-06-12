/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountService.Entities;


namespace DiscountService.Data
{
    public interface IApplicationDbContext
    {
       
        DbSet<Discount> Discounts { get; set; }
        

        Task<int> SaveDiscountChanges();
       

    }
}
