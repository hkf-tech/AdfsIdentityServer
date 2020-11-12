using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;

namespace ScottBrady91.IdentityServer3.Example.Configuration
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "abc",
                    Password = "abc",
                    Subject = "1",
                    Claims = new List<Claim>
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "abc"),
                        new Claim(Constants.ClaimTypes.FamilyName, "abc"),
                        new Claim(Constants.ClaimTypes.Email, "give@email.com"),
                        new Claim(Constants.ClaimTypes.Role, "giveRole"),
                        new Claim("upn", "upn"),
                        new Claim("displayname", "Dct Preprod"),
                        new Claim(Constants.ClaimTypes.Name, "Peterborough"),
                        new Claim("mail","givemail@gmail.com"),
                        new Claim("ukprn", "ukprn"),
                        new Claim("reservation", "true"),
                        new Claim("service",""),
                        new Claim("service","")
                    }
                }
            };
        }
    }
}
