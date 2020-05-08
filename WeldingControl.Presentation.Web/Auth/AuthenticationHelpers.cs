using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using WeldingControl.Shared.Constants;
using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Presentation.Web.Auth
{
    public static class AuthenticationHelpers
    {
        private static readonly Dictionary<string, Position> roleToPositionMap = new Dictionary<string, Position>
        {
            {Roles.Welder, Position.Welder },
            {Roles.Master, Position.Master },
            {Roles.Supervisor, Position.Supervisor },
        };

        public static JwtUserData GetUserDataFromJwt(this HttpContext context)
        {
            var claims = context.User.Claims.ToList();

            var userName = claims.FirstOrDefault(x => x.Type == "preferred_username");

            if (userName == null)
            {
                return null;
            }

            var role = claims.First(x => x.Type == ClaimsIdentity.DefaultRoleClaimType);

            return new JwtUserData
            {
                UserName = userName.Value,
                Position = roleToPositionMap[role.Value],
            };
        }
    }
}