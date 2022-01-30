using OnlineChat.Bll.EfCore.Abstract.Rooms;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;
using OnlineChat.Entity.Rooms;

namespace OnlineChat.Bll.EfCore.Concrete.Rooms
{
    public class RoomRepository : EntityBaseRepository<Room>,IRoomRepository
    {
        public RoomRepository(OnlineChatContext context):base(context)
        {
            
        }
    }
}
