using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineChat.Core.Entities.Users;
using OnlineChat.Core.Extensions;
using OnlineChat.Core.Utilities.Encryption;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace OnlineChat.Core.Utilities.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration _configuration { get; }
        private readonly TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }


        public AccessToken CreateToken(User user, List<Role> roles)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);

            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, roles);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration,
                UserId = user.Id
            };
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<Role> roles)
        {
            var jwt = new JwtSecurityToken(
               issuer: tokenOptions.Issuer,
               audience: tokenOptions.Audience,
               expires: _accessTokenExpiration,
               notBefore: DateTime.Now,
               claims: SetClaims(user, roles),
               signingCredentials: signingCredentials
           );
            return jwt;
        }
        private IEnumerable<Claim> SetClaims(User user, List<Role> roles)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.Surname} {user.Name}");
            claims.AddRoles(roles.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
