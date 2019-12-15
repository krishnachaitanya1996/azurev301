using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Infra.Repositories
{
    public class RegisteredUsersRepository : Repository<RegisteredUsers>, IRegisteredUsersRepository
    {
        public RegisteredUsersRepository(HotelDbContext hotelDbContext) : base(hotelDbContext) { }
    }
}
