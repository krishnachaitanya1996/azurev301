using MyStay.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.IServices
{
    public interface IRegisteredUsersServices
    {
        IEnumerable<RegisteredUsers> GetAllRegisteredUsersDetails();
        int PostRegisteredUsersDetails(RegisteredUsers registeredUsers);
    }
}
