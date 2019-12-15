using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStay.Core.ApplicationServices.Services
{
    public class BookingServices : IBookingServices
    {
        readonly IBookingRepository _bookingRepo;
        readonly IUnitOfWork _unitOfWork;

        public BookingServices(IBookingRepository bookingRepo, IUnitOfWork unitOfWork)
        {
            _bookingRepo = bookingRepo;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Booking> GetAllBookingDetails()
        {
            IEnumerable<Booking> bookings = _unitOfWork.bookingRepository.GetAll();
            foreach(Booking booking in bookings)
            {
                booking.HotelName = _unitOfWork.hotels.Get(booking.ParentHotelID).Name;
                booking.RoomNumber = _unitOfWork.roomRepository.Get(booking.ParentRoomID).RoomNumber;
                Payment payment = _unitOfWork.paymentRepository.GetAll().AsEnumerable().Where(x=>x.ParentBookingID==booking.ID).FirstOrDefault();
                booking.PaidStatus = payment == null?string.Empty: payment.PaymentStatus;
            }

            return bookings;
        }

        public int PostBookingDetails(Booking booking)
        {
            return _unitOfWork.bookingRepository.Add(booking);
        }
    }
}
