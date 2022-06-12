/* IT19152110
 * Rajapaksha K.D.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Entities
{
    public class Payment : BaseEntity
    {
        public String CardNo{ get; set; }

        public String Name_On_Card { get; set; }

        public String Expire_Date { get; set; }

        public int CVC { get; set; }

        public int Total_Amount { get; set; }

    }
}
