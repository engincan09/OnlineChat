using OnlineChat.Core.Entities.Users;
using System.Collections.Generic;

namespace OnlineChat.Core.Utilities.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<UserRole> userRole);
    }
}
