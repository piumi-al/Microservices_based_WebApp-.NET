/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Entities
{
    public class Product : BaseEntity
    {

      
        public String Product_Name { get; set; }

        public String Code { get; set; }

        public int Quantity_In_Stock { get; set; }

        public int Unit_Price { get; set; }


    }
}
