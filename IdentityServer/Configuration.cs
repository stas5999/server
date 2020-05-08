using System.Collections.Generic;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using WeldingControl.Shared.Constants;

namespace IdentityServer
{
    public static class Configuration
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResource
            {
                Name = "wect.profile",
                DisplayName = "Welding Control Profile",
                UserClaims =
                {
                    "preferred_username",
                    "role",
                }
            }
        };

        public static IEnumerable<ApiResource> GetApiResources() => new List<ApiResource>
        {
            new ApiResource(
                "wect.api", 
                new[]
                {
                    "preferred_username", 
                    "role",
                })
        };

        public static IEnumerable<Client> GetClients() => new List<Client>
        {
            new Client
            {
                ClientId = "client_id",
                ClientSecrets = {new Secret("client_secret".ToSha256())},

                AllowedGrantTypes = GrantTypes.Implicit,

                RedirectUris = {"http://localhost:44325/signin"},
                AllowedCorsOrigins = {"http://localhost:44325"},
                PostLogoutRedirectUris = { "http://localhost:44325" },

                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    "wect.profile",
                    "wect.api",
                },
                AllowAccessTokensViaBrowser = true,
                RequireConsent = false,
            }
        };
    }
}