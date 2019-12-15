using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStayMVC.Models
{
    public class RoomDetails
    {
        public RoomDetails()
        {
            lstRoomDetails = new List<RoomDetails>();
        }
        public int ID { get; set; }
        public int ParentHotelID { get; set; }

        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public int? NumberofBeds { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string RoomStatus { get; set; }
        [Required]
        public string Service { get; set; }
        public string HotelName { get; set; }
       
        public List<RoomDetails> lstRoomDetails { get; set; }
    }

    public enum RoomType
    {
        Luxury,
        [DisplayName("Non-Luxury")] NonLuxury
    }

    public enum Services
    {
        [DisplayName("All-Day Breakfast")] AllDayBreakfast,
        [DisplayName("Pick-up/Drop-off")] PickupDropoff,
        [DisplayName("Luggage Forwarding")] LuggageForwarding
       
    }
}
