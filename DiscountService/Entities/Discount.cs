/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountService.Entities
{
    public class Discount : BaseEntity
    {

        public int productID { get; set; }

        public String Discount_Type{ get; set; }

        public int Discount_amount { get; set; }

        public String start_date { get; set; }

        public String end_date { get; set; }

    

    }
}
