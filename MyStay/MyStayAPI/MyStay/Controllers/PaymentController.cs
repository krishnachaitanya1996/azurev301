using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;
using MyStayAPI.AzureServices;

namespace MyStayAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentServices _paymentServices;

        public PaymentController(IPaymentServices paymentServices)
        {
            _paymentServices = paymentServices;
        }

        [HttpPost]
        [Route("api/[controller]/PostPaymentDetails")]
        public IActionResult PostPaymentDetails([FromBody]Payment paymentDetails)
        {
            try
            {
                int response = _paymentServices.PostPaymentDetails(paymentDetails);
                if (response > 0)
                {
                    ServiceBusQueue.AzureServiceBusQueue().GetAwaiter();
                }
                return Ok(_paymentServices.PostPaymentDetails(paymentDetails));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/[controller]/GetAllPaymentDetails")]
        public IEnumerable<Payment> GetAllPaymentDetails()
        {
            return _paymentServices.GetAllPaymentDetails();
        }
    }
}