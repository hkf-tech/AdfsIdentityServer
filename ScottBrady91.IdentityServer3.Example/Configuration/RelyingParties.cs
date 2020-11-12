﻿namespace ScottBrady91.IdentityServer3.Example.Configuration
{
    using System.Collections.Generic;
    using System.Security.Claims;

    using IdentityModel.Constants;

    using global::IdentityServer3.WsFederation.Models;

    public static class RelyingParties
    {
        public static IEnumerable<RelyingParty> Get()
        {
            return new List<RelyingParty>
                       {
                           new RelyingParty
                               {
                                   Realm = "", 
                                   Name = "PAS", 
                                   Enabled = true, 
                                   ReplyUrl = "https://127.0.0.1:44347/account", 
                                   TokenType = TokenTypes.Saml2TokenProfile11, 
                                   ClaimMappings =
                                       new Dictionary<string, string>
                                           {
                                               { "sub", ClaimTypes.NameIdentifier }, 
                                               { "name", ClaimTypes.Name }, 
                                               { "given_name", ClaimTypes.GivenName }, 
                                               { "family_name", ClaimTypes.Surname }, 
                                               { "email", ClaimTypes.Email }, 
                                               { "upn", ClaimTypes.Upn },
                                               {"displayname", "http://schemas.portal.com/displayname" },
                                               {"mail", "http://schemas.portal.com/mail" },
                                               {"ukprn", "http://schemas.portal.com/ukprn" },
                                               {"reservation","http://schemas.portal.com/reservations" },
                                               {"service","http://schemas.portal.com/service" }
                                           }
                               },

                             new RelyingParty
                               {
                                   Realm = "https://localhost:5001/",
                                   Name = "ProviderCommitmentV2",
                                   Enabled = true,
                                   ReplyUrl = "https://localhost:5001/signin-wsfed",
                                   TokenType = TokenTypes.Saml2TokenProfile11,
                                   ClaimMappings =
                                       new Dictionary<string, string>
                                           {
                                               { "sub", ClaimTypes.NameIdentifier },
                                               { "name", ClaimTypes.Name },
                                               { "given_name", ClaimTypes.GivenName },
                                               { "family_name", ClaimTypes.Surname },
                                               { "email", ClaimTypes.Email },
                                               { "upn", ClaimTypes.Upn },
                                               {"displayname", "http://schemas.portal.com/displayname" },
                                               {"mail", "http://schemas.portal.com/mail" },
                                               {"ukprn", "http://schemas.portal.com/ukprn" },
                                               {"reservation","http://schemas.portal.com/reservations" },
                                               {"service","http://schemas.portal.com/service" }
                                           }
                               }
                       };
        }
    }
}