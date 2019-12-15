using MyStay.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.IServices
{
    public interface IPaymentServices
    {
        IEnumerable<Payment> GetAllPaymentDetails();
        int PostPaymentDetails(Payment payment);
    }
}
