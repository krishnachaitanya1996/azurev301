using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.Services
{
    public class RoomServices : IRoomServices
    {
        readonly IRoomRepository _RoomRepo;
        private IUnitOfWork _unitOfWork;

        public RoomServices(IRoomRepository RoomRepository, IUnitOfWork unitOfWork)
        {
            _RoomRepo = RoomRepository;
            _unitOfWork = unitOfWork;
        }
        public int PostRoomDetails(RoomDetails roomDetails)
        {
            return _unitOfWork.roomRepository.Add(roomDetails);
        }

        public IEnumerable<RoomDetails> GetAllRoomDetails()
        {
            return _unitOfWork.roomRepository.GetAll();
        }
    }
}
