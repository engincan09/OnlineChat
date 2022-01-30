using OnlineChat.Bll.EfCore.Abstract.Users;
using OnlineChat.Core.Entities.Users;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;

namespace OnlineChat.Bll.EfCore.Concrete.Users
{
    public class RoleRepository : EntityBaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
