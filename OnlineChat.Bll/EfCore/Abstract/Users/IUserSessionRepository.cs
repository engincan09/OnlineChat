using OnlineChat.Dal.EfCore.Abstract;
using OnlineChat.Entity.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Bll.EfCore.Abstract.Users
{
    public interface IUserSessionRepository : IEntityBaseRepository<UserSession>
    {
    }
}
