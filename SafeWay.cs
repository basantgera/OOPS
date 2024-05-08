using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
     class Safeway
    {
      private int SafewayOrderId { get; set; }
      public int billingId { get; set; } 
      public double price { get; set; }
      public int quantity { get; set; }

    }

    class SafeWayBilling
    {
        private int billingId { get; set; }
        public string addedBy { get; set; }
        public string updatedBy { get; set; }
        public DateTime addedOn { get; set; }
        public DateTime updatedOn { get; set; }
        public string creditCardNumber { get; set; }
    }
}
