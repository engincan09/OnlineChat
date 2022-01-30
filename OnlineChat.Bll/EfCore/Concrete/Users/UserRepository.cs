using OnlineChat.Bll.EfCore.Abstract.Users;
using OnlineChat.Core.Entities.Users;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;

namespace OnlineChat.Bll.EfCore.Concrete.Users
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
