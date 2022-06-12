using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Entities
{
    public class Delivery : BaseEntity
    {

        public int  OrderID { get; set; }

        public String Delivery_ProductName { get; set; }

        public String Delivery_Contact{ get; set; }

        public String Delivery_location { get; set; }

        public int Delivery_charge { get; set; }

    }
}
