using OnlineChat.Bll.EfCore.Abstract.Users;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;
using OnlineChat.Entity.Users;

namespace OnlineChat.Bll.EfCore.Concrete.Users
{
    public class UserSessionRepository : EntityBaseRepository<UserSession>, IUserSessionRepository
    {
        public UserSessionRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
