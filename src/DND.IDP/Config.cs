using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace DND.IDP
{

    //https://leastprivilege.com/2016/12/16/identity-vs-permissions/
    //https://policyserver.io/
    //https://github.com/policyserver/policyserver.local

    public static class Config
    {
        // test users
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "Frank",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Frank"),
                        new Claim("family_name", "Underwood"),
                        new Claim("address", "Main Road 1"),
                        new Claim("role", "Admin"), //Permissions
                        new Claim("subscriptionlevel", "FreeUser"),
                        new Claim("country", "nl")
                    }
                },
                new TestUser
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "Claire",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Claire"),
                        new Claim("family_name", "Underwood"),
                        new Claim("address", "Big Street 2"),
                        new Claim("role", "PayingUser"), //Permissions
                        new Claim("subscriptionlevel", "PayingUser"),
                        new Claim("country", "be")
                    }
                }
            };
        }

        // identity-related resources (scopes)
        // Audience = Scope
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResource(
                    "roles",
                    "Your roles(s)",
                    new List<string>(){"role"} )
                    ,
                new IdentityResource(
                    "country",
                    "The country you're living in",
                    new List<string>() { "country" }),
                new IdentityResource(
                    "subscriptionlevel",
                    "Your subscription level",
                    new List<string>() { "subscriptionlevel" })
            };
        }

        //Audience = Resource
        //Scope = Sub-Resource. If No scopes Audience = Scope
        //https://docs.identityserver.io/en/release/reference/api_resource.html
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {

                //audience
                new ApiResource("api", "My API", new List<string>() {"role" , "scope" }) //include in access_token
                {
                    ApiSecrets = {new Secret("apisecret".Sha256())} // Only required if AccessTokenType = AccessTokenType.Reference
                    //Generally an IdentityServer Client with users will have access to ALL scopes, and user permissions will be handled by Claims.
                    //Api Scopes gives the ability to set max permission level of an application(client).
                    //User permissions are then down by Claims.
                    ,Scopes =
                    {
                        new Scope()
                        {
                            Name = ApiScopes.Full,
                            DisplayName = "Full access to API"
                        },
                         new Scope
                        {
                            Name = ApiScopes.Write,
                            DisplayName = "Write access to API"
                        },
                        new Scope
                        {
                            Name = ApiScopes.Create,
                            DisplayName = "Create only access to API"
                        },
                        new Scope
                        {
                            Name = ApiScopes.Read,
                            DisplayName = "Read only access to API"
                        },
                        new Scope
                        {
                            Name = ApiScopes.Update,
                            DisplayName = "Update only access to API"
                        },
                        new Scope
                        {
                            Name = ApiScopes.Delete,
                            DisplayName = "Delete only access to API"
                        }
                        ,
                        new Scope
                        {
                            Name = ApiScopes.Notifications,
                            DisplayName = "Notifications access to API"
                        }
                    }
                }
            };
        }

       
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                //http://docs.identityserver.io/en/latest/quickstarts/1_client_credentials.html#refclientcredentialsquickstart
                //https://auth0.com/docs/api-auth/which-oauth-flow-to-use#is-the-client-absolutely-trusted-with-user-credentials-

                 //Server Initiation to Server Api
                 // no interactive user, use the clientid/secret for authentication
                new Client
                {
                    ClientName = "API Client",
                    ClientId = "api_server_client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AccessTokenType = AccessTokenType.Jwt,
                    ClientSecrets = new[] { new Secret("secret".Sha256()) },
                   //api scopes client is allowed to request
                    AllowedScopes = new List<string> {
                        ApiScopes.Full ,
                        ApiScopes.Create,
                        ApiScopes.Read,
                        ApiScopes.Update,
                        ApiScopes.Delete
                    },
                    AllowOfflineAccess = false //Refresh Tokens
                },
                //Client Initiation to Server Api
                //ASP.NET Core 2 Authentication Playbook Video 8

                //https://developer.okta.com/blog/2019/08/22/okta-authjs-pkce
                //If the Client is a Single Page App, an application running in a browser using a scripting language like JavaScript, there are two grant options: the Authorization Code Grant using Proof Key for Code Exchange (PKCE) and the Implicit Grant.For most cases, we recommend using the Authorization Code Grant with PKCE.
                
                //People always ask me why Implicit Flow was recommended in the first place if Authorization Code Flow is inherently more secure.This is largely due to the fact that for many years browsers prevented JavaScript from making an HTTP request to a server that was hosted in a different domain.Implicit Flow was a way to work around this restriction by leveraging the redirection url.Tokens could be passed in the redirect URL instead of making a direct HTTP request.Fortunately, this is no longer required as the majority of modern browsers support Cross - Origin Resource Sharing(CORS).
                //This new capability, opens the door for the Authorization Code Flow.Unlike Implicit Flow, Authorization Code Flow happens in two steps.First, an Authorization Code is requested.
                //https://christianlydemann.com/implicit-flow-vs-code-flow-with-pkce/
                //https://www.pingidentity.com/en/company/blog/posts/2018/securely-using-oidc-authorization-code-flow-public-client-single-page-apps.html
                // Use of refresh tokens. (This is a big one.)
                //Greater control over the user session timeout via spec-defined mechanisms.
                //Consistency across various use cases (SPA, native mobile apps, native desktop apps, web applications, etc).

               //Public client
               new Client
                {
                    ClientName = "Spa",
                    ClientId = "spa",
                    AllowedGrantTypes = GrantTypes.Code, //Previously Implicit. Also, this flow does not return a Refresh Token because the browser cannot keep it private.
                    RequirePkce = true,
                    RequireClientSecret = false, //turn off for public clients
                    AccessTokenType = AccessTokenType.Jwt,
                    AllowAccessTokensViaBrowser = true,
                    //api scopes client is allowed to request              
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        ApiScopes.Read
                    },
                    RedirectUris = {
                        "https://localhost:5001/SignInCallback.html",
                        "https://localhost:44372/SignInCallback.html",

                        "https://localhost:44332/signin-oidc",
                        "https://localhost:44332/redirect-silentrenew",
                    },
                    PostLogoutRedirectUris = {
                        "https://localhost:5001/SignOutCallback.html",
                        "https://localhost:44372/SignOutCallback.html",
                        "https://localhost:44332/"
                    },
                    AllowedCorsOrigins = {
                        "https://localhost:5001",
                        "https://localhost:44372",
                        "https://localhost:44332"
                    }, //CORS for IDP
                    RequireConsent = false, //Consent screen
                    AccessTokenLifetime = 1200,
                    AllowOfflineAccess = false, //Refresh Tokens
                },
                //Public client
                //Native Mobile App
                //If the Application is a native app, then the Authorization Code Flow with PKCE (Authorization Code Grant using Proof Key for Code Exchange) should be used.
                 new Client
                {
                    ClientName = "Native",
                    ClientId = "native",
                    AllowedGrantTypes = GrantTypes.Code,
                    AccessTokenType = AccessTokenType.Jwt,
                    RequirePkce = true,
                    RequireClientSecret = false, //turn off for public clients
                     //api scopes client is allowed to request
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        ApiScopes.Read
                    },
                    RedirectUris = {
                        "https://localhost:5001/SignInCallback.html",
                        "https://localhost:44372/SignInCallback.html",

                        "https://localhost:44332/signin-oidc",
                        "https://localhost:44332/redirect-silentrenew",
                    },
                    PostLogoutRedirectUris = {
                        "https://localhost:5001/SignOutCallback.html",
                        "https://localhost:44372/SignOutCallback.html",
                        "https://localhost:44332/"
                    },
                    AllowedCorsOrigins = {
                        "https://localhost:5001",
                        "https://localhost:44372",
                        "https://localhost:44332"
                    }, //CORS for IDP
                    RequireConsent = false, //Consent screen
                    AccessTokenLifetime = 1200,
                    AllowOfflineAccess = false, //Refresh Tokens
                },
                 //Confidential client
                 //Calling APIs on behalf of user
                new Client
                {
                    ClientName = "MVC Client",
                    ClientId = "mvc_client",
                    AllowedGrantTypes = GrantTypes.Code,//Hybrid for MVC Client OR Code without Secret + PKCE. With .NET Core easiest just to use Authorization = 'code' & PKCE (.Net Core automatically uses PKCE for for code) rather than Hybrid = 'code id_token' + secret
                    //https://auth0.com/docs/flows/concepts/auth-code-pkce
                    //https://www.scottbrady91.com/OpenID-Connect/ASPNET-Core-using-Proof-Key-for-Code-Exchange-PKCE
                    AccessTokenType = AccessTokenType.Reference, //More control over lifetime with Reference. Requires Api to have ApiSecret
                    RequirePkce = true,
                    RequireClientSecret = true, //turn on for confidential clients
                    RequireConsent = false, //Consent screen. This is typically only necessary for third-party clients.
                    IdentityTokenLifetime = 300,
                    AuthorizationCodeLifetime = 300,
                    AccessTokenLifetime = 1200,
                    AllowOfflineAccess = true, //Refresh Tokens
                    AbsoluteRefreshTokenLifetime = 2592000, //30 days
                    UpdateAccessTokenClaimsOnRefresh = true,
                    RedirectUris = new List<string>()
                    {
                        "https://localhost:5001/signin-oidc",
                        "https://localhost:44372/signin-oidc"
                    },
                    PostLogoutRedirectUris = new List<string>()
                    {
                        "https://localhost:5001/signout-callback-oidc",
                        "https://localhost:44372/signout-callback-oidc"
                    },
                     //api scopes client is allowed to request, best to break it 
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        "roles",
                        ApiScopes.Read,
                        "country",
                        "subscriptionlevel"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    }
                },
            };
        }
    }
}
