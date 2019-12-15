using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.Services
{
    public class PaymentServices : IPaymentServices
    {
        readonly IPaymentRepository _paymentRepo;
        readonly IUnitOfWork _unitOfWork;

        public PaymentServices(IPaymentRepository paymentRepo, IUnitOfWork unitOfWork)
        {
            _paymentRepo = paymentRepo;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Payment> GetAllPaymentDetails()
        {
            return _unitOfWork.paymentRepository.GetAll();
        }

        public int PostPaymentDetails(Payment payment)
        {
            return _unitOfWork.paymentRepository.Add(payment);
        }
    }
}
