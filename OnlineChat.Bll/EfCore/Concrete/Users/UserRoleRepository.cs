using OnlineChat.Bll.EfCore.Abstract.Users;
using OnlineChat.Core.Entities.Users;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;

namespace OnlineChat.Bll.EfCore.Concrete.Users
{
    public class UserRoleRepository : EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
