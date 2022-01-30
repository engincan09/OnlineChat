using OnlineChat.Dal.EfCore.Abstract;
using OnlineChat.Entity.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Bll.EfCore.Abstract.Rooms
{
    public interface IRoomRepository : IEntityBaseRepository<Room>
    {
    }
}
