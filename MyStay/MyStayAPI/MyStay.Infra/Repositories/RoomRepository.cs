using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Infra.Repositories
{
    public class RoomRepository : Repository<RoomDetails>, IRoomRepository
    {
        public RoomRepository(HotelDbContext hotelDbContext) : base(hotelDbContext)
        {
        }
    }
}
