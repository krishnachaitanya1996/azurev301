using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.Entity
{
    public class RoomDetails
    {
        public int ID { get; set; }
        public int ParentHotelID { get; set; }
        public string RoomNumber { get; set; }
        public int NumberofBeds { get; set; }
        public decimal Price { get; set; }
        public string RoomType { get; set; }
        public string RoomStatus { get; set; }

        public string Service { get; set; }

    }
}
