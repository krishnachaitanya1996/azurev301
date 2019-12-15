using MyStay.Core.Entity;
using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Infra.Repositories
{
    public class LoginRepository: Repository<Login>, ILoginRepository
    {
        public LoginRepository(HotelDbContext hotelDbContext) : base(hotelDbContext)
        {
        }
    }
}
