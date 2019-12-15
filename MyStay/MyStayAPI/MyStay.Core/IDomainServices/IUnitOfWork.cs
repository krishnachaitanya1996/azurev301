using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.IDomainServices
{
   public interface IUnitOfWork : IDisposable
    {
        IHotelInfoRepository hotels { get;  }
        ILoginRepository loginRepository { get; }
        IRoomRepository roomRepository { get; }
        IBookingRepository bookingRepository { get;}
        IRegisteredUsersRepository registeredUsersRepository { get;}
        IPaymentRepository paymentRepository { get;}
        int Complete();
    }
}
