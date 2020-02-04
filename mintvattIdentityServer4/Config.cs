using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace mintvattIdentityServer4
{
    public class Config
    {

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "Danmalmx",
                    Password = "1234"
                },
                   new TestUser
                {
                    SubjectId = "2",
                    Username = "Bobster",
                    Password = "1234"
                },
            };
        }
   

        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("mintvattAPI", "User Api for mitvatt")
            };
        }

        public static IEnumerable<Client> GetClients()
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
