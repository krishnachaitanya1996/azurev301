using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyStay.Core.Entity;

namespace MyStay.Infra
{
  public  class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
     : base(options)
        {

        }
        public DbSet<HotelInfo> HotelInfo { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<RoomDetails> Room { get; set; }
        public DbSet<Booking> booking { get; set; }
        public DbSet<RegisteredUsers> registeredUsers { get; set; }
        public DbSet<Payment> payment { get; set; }
    }
}
