using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyStay.Core.Entity
{
   public class Booking
    {
        public int ID { get; set; }
        public int ParentHotelID { get; set; }
        public int ParentRoomID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string HotelName { get; set; }
        [NotMapped]
        public string RoomNumber { get; set; }
        [NotMapped]
        public string PaidStatus { get; set; }
    }
}
