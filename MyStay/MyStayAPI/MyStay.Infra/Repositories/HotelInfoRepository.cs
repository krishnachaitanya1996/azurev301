using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Infra.Repositories
{
    public class HotelInfoRepository : Repository<HotelInfo>, IHotelInfoRepository
    {
        public HotelInfoRepository(HotelDbContext hotelDbContext) : base(hotelDbContext)
        {
            //_customerDbContext = customerDbContext;
        }
    }
}
