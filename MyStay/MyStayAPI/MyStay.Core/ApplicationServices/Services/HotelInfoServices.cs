using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.Services
{
    public class HotelInfoServices : IHotelInfoServices
    {
        readonly IHotelInfoRepository _HotelInfoRepo;
        private IUnitOfWork _unitOfWork;
        public HotelInfoServices(IHotelInfoRepository hotelInfoRepository, IUnitOfWork unitOfWork)
        {
            _HotelInfoRepo = hotelInfoRepository;
            _unitOfWork = unitOfWork;
        }
        public int PostHotelDetails(HotelInfo hotelInfo)
        {
            return _unitOfWork.hotels.Add(hotelInfo);
        }

        public IEnumerable<HotelInfo> GetAllHotelInfo()
        {
            return _unitOfWork.hotels.GetAll();
        }
    }
}
