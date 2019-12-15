using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.Entity
{
   public class Payment
    {
        public int ID { get; set; }
        public int ParentBookingID { get; set; }
        public string PaymentStatus { get; set; }
    }
}
