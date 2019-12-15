using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Infra.Repositories
{
    public class BookingRepository: Repository<Booking>,IBookingRepository
    {
        public BookingRepository(HotelDbContext hotelDbContext) : base(hotelDbContext) { }
    }
}
