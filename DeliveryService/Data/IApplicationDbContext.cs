/* IT19207964
 * Weerasooriya K.T.N.
 */
using DeliveryService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Data
{
    public interface IApplicationDbContext
    {
       
        DbSet<Delivery> Deliveries{ get; set; }
        

        Task<int> SaveDeliveryChanges();
       

    }
}
