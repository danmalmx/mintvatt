using System;
using System.Collections.Generic;
using IdentityServer4.Models;

namespace mintvattIdentityServer4
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("mintvattAPI", "User Api for mitvatt")
            };
        }

        public static IEnumerable<Client> GetUsers()
        {
            return new List<Client> {

                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "mintvattAPI" }

                }
            };
        }
    }
}
