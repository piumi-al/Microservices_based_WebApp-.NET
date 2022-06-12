/* IT19207964
 * Weerasooriya K.T.N.
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Data
{
    public interface IApplicationDbContext
    {
       
        DbSet<UserService.Entites.User> Users { get; set; }
        

        Task<int> SaveUserChanges();
       

    }
}
