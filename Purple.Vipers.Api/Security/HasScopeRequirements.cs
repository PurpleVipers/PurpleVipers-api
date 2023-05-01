using Microsoft.AspNetCore.Authorization;

namespace Purple.Vipers.Api.Security
{

    public class HasScopeRequirements : IAuthorizationRequirement
    {
        public string Issuer { get; }
        public string Scope { get; }

        public HasScopeRequirements(string scope, string issuer)
        {
            Scope = scope ?? throw new System.ArgumentNullException(nameof(scope));
            Issuer = issuer ?? throw new System.ArgumentNullException(nameof(issuer));
        }
    } 
}