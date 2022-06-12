/* IT19152110
 * Rajapaksha K.D.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Entities;


namespace PaymentService.Data
{
    public interface IApplicationDbContext
    {
       
        DbSet<Payment> Payments { get; set; }
        

        Task<int> SavePaymentChanges();
       

    }
}
