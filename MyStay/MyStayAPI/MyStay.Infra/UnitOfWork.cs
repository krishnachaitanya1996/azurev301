using MyStay.Core.IDomainServices;
using MyStay.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Infra
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelDbContext _context;
        public IHotelInfoRepository hotels { get; private set; }
        public ILoginRepository loginRepository { get; private set; }
        public IRoomRepository roomRepository { get; private set; }
        public IBookingRepository bookingRepository { get; private set; }
        public IRegisteredUsersRepository registeredUsersRepository { get; private set; }
        public IPaymentRepository paymentRepository { get; private set; }

        //public IHotelInfoRepository hotels => throw new NotImplementedException();

        public UnitOfWork(HotelDbContext context)
        {
            _context = context;
            hotels= new HotelInfoRepository(_context);
            loginRepository = new LoginRepository(_context);
            roomRepository = new RoomRepository(_context);
            bookingRepository = new BookingRepository(_context);
            registeredUsersRepository = new RegisteredUsersRepository(_context);
            paymentRepository = new PaymentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
       
    }
}
