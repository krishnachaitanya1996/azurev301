using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStayMVC.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public int ParentBookingID { get; set; }
        public string PaymentStatus { get; set; }
    }
}
