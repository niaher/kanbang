namespace Kanbang.Web.Logic.Security
{
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Security.Claims;
	using System.Security.Principal;
	using Coderful.Web.Identity;
	using Kanbang.Core.Domain;

	public class AppAuthenticator : Authenticator
	{
		protected override ClaimsPrincipal GetApplicationPrincipal(IPrincipal incomingPrincipal)
		{
			var user = GetUser(incomingPrincipal);

			var claims = this.GetClaims(user);

			var identity = new ClaimsIdentity(claims);
			return new ClaimsPrincipal(identity);
		}

		protected IEnumerable<Claim> GetClaims(User user)
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
				new Claim(ClaimTypes.GivenName, user.Name),
			};

			// TODO: add more claims.
			claims.Add(new Claim(ClaimTypes.UserData, "View-AdminDashboard"));
			claims.Add(new Claim(ClaimTypes.UserData, "View-Secret"));

			return claims;
		}

		private static User GetUser(IPrincipal userPrincipal)
		{
			return new User();
		}
	}
}