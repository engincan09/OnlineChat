using OnlineChat.Core.Entities.Users;
using OnlineChat.Dal.EfCore.Abstract;

namespace OnlineChat.Bll.EfCore.Abstract.Users
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
    }
}
