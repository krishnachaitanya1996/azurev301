using MyStay.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.IServices
{
    public interface IHotelInfoServices
    {
        IEnumerable<HotelInfo> GetAllHotelInfo();
        int PostHotelDetails(HotelInfo hotelInfo);

    }
}
