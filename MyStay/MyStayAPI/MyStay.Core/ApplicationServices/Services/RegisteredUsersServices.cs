using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.Services
{
    public class RegisteredUsersServices : IRegisteredUsersServices
    {
        readonly IRegisteredUsersRepository _registeredUsersRepo;
        readonly IUnitOfWork _unitOfWork;

        public RegisteredUsersServices(IRegisteredUsersRepository registeredUsersRepo, IUnitOfWork unitOfWork)
        {
            _registeredUsersRepo = registeredUsersRepo;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<RegisteredUsers> GetAllRegisteredUsersDetails()
        {
            return _unitOfWork.registeredUsersRepository.GetAll();
        }

        public int PostRegisteredUsersDetails(RegisteredUsers registeredUsers)
        {
            return _unitOfWork.registeredUsersRepository.Add(registeredUsers);
        }
    }
}
