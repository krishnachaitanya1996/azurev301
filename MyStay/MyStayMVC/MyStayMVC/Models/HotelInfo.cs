using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStayMVC.Models
{
    public class HotelInfo
    {
        public HotelInfo()
        {
            lstHotelInfo = new List<HotelInfo>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<HotelInfo> lstHotelInfo { get; set; }
    }
}
