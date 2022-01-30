using OnlineChat.Dal.EfCore.Abstract;
using OnlineChat.Entity.Users;

namespace OnlineChat.Bll.EfCore.Abstract.Users
{
    public interface IUserSessionRepository : IEntityBaseRepository<UserSession>
    {
    }
}
