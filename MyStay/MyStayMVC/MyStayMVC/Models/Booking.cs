using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStayMVC.Models
{
    public class Booking
    {
        public Booking()
        {
            lstBooking = new List<Booking>();
        }
        public int ID { get; set; }
        public int ParentHotelID { get; set; }
        public int ParentRoomID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string HotelName { get; set; }
        public string RoomNumber { get; set; }
        public List<Booking> lstBooking { get; set; }
        public string Selectedvalue { get; set; }
        public string PaidStatus { get; set; }
    }
}
