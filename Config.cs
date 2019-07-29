// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            return new ApiResource[] { 
                new ApiResource("mikupedia", "kagajr.com/miku-api"),
                new ApiResource("identity", "kagajr.com/identity-api")
             };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new Client[] { 
                new Client {
                    ClientId = "ng-kagajr.com/miku",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets = {
                        new Secret("mikuchankawaii".Sha256())
                    },

                    AllowedScopes = {
                        "mikupedia",
                        "identity"
                    }
                }
            };
        }
    }
}