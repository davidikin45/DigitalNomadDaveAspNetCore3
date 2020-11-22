using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Authorization.PolicyProviders
{
    //https://www.jerriepelser.com/blog/creating-dynamic-authorization-policies-aspnet-core/
    //https://medium.com/@kadir.kilicoglu_67563/asp-net-core-custom-authorization-policies-with-multiple-requirements-and-multiple-handlers-487f920ae13e

    public class DynamicClaimPolicyProvider : IAuthorizationPolicyProvider
    {
        private readonly AuthorizationOptions _options;
        public DefaultAuthorizationPolicyProvider FallbackPolicyProvider { get; }

        public DynamicClaimPolicyProvider(IOptions<AuthorizationOptions> options)
        {
            _options = options.Value;
            FallbackPolicyProvider = new DefaultAuthorizationPolicyProvider(options);
        }

        public Task<AuthorizationPolicy> GetDefaultPolicyAsync() => FallbackPolicyProvider.GetDefaultPolicyAsync();

        public Task<AuthorizationPolicy> GetFallbackPolicyAsync() => FallbackPolicyProvider.GetFallbackPolicyAsync();

        public async Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            // Check static policies first
            var policy = await FallbackPolicyProvider.GetPolicyAsync(policyName);

            if (policy == null)
            {
                if(policyName.Contains("$"))
                {
                    var pair = policyName.Split('$', StringSplitOptions.RemoveEmptyEntries);

                    if (pair?.Any() == true && pair.Length == 2)
                    {
                        if(string.Equals(pair[0], "scope", StringComparison.OrdinalIgnoreCase))
                        {
                            policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .RequireScope(pair[1].Split(',', StringSplitOptions.RemoveEmptyEntries)).Build();
                        }
                        else
                        {
                            policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .RequireClaim(pair[0], pair[1].Split(',', StringSplitOptions.RemoveEmptyEntries)).Build();
                        }

                        // Add policy to the AuthorizationOptions, so we don't have to re-create it each time
                        _options.AddPolicy(policyName, policy);
                    }
                }
            }

            return policy;
        }
    }
}
