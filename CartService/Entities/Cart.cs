/* IT19152110
 * Rajapaksha K.D.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartService.Entities
{
    public class Cart : BaseEntity
    {

        public int ProductId { get; set; }

        public String Addede_Date { get; set; }

        public int Quantity { get; set; }

        public int sub_total { get; set; }


    }
}
