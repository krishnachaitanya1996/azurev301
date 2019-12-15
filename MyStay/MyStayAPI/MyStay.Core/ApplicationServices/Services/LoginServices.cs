using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.Services
{
    public class LoginServices : ILoginServices
    {
        readonly ILoginRepository _LoginRepo;
        private IUnitOfWork _unitOfWork;

        public LoginServices(ILoginRepository LoginRepository, IUnitOfWork unitOfWork)
        {
            _LoginRepo = LoginRepository;
            _unitOfWork = unitOfWork;
        }
        public int PostLogin(Login login)
        {
           return _unitOfWork.loginRepository.Add(login);
        }
    }
}
