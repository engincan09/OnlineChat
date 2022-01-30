using OnlineChat.Bll.EfCore.Abstract.Users;
using OnlineChat.Dal.EfCore;
using OnlineChat.Dal.EfCore.Concrete;
using OnlineChat.Entity.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Bll.EfCore.Concrete.Users
{
    public class UserSessionRepository : EntityBaseRepository<UserSession>, IUserSessionRepository
    {
        public UserSessionRepository(OnlineChatContext context) : base(context)
        {

        }
    }
}
