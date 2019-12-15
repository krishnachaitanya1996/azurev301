using MyStay.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStay.Core.ApplicationServices.IServices
{
    public interface IRoomServices
    {
        IEnumerable<RoomDetails> GetAllRoomDetails();
        int PostRoomDetails(RoomDetails roomDetails);
    }
}
