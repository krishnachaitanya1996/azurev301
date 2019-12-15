using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;

namespace MyStayAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class RegisteredUsersController : ControllerBase
    {
        private readonly IRegisteredUsersServices _registeredUsersServices;

        public RegisteredUsersController(IRegisteredUsersServices registeredUsersServices)
        {
            _registeredUsersServices = registeredUsersServices;
        }

        [HttpPost]
        [Route("api/[controller]/PostRegisteredUsersDetails")]
        public IActionResult PostRegisteredUsersDetails([FromBody]RegisteredUsers registeredUsersDetails)
        {
            try
            {
                return Ok(_registeredUsersServices.PostRegisteredUsersDetails(registeredUsersDetails));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/[controller]/GetAllRegisteredUsersDetails")]
        public IEnumerable<RegisteredUsers> GetAllRegisteredUsersDetails()
        {
            return _registeredUsersServices.GetAllRegisteredUsersDetails();
        }
    }
}