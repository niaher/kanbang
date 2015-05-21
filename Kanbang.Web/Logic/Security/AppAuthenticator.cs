namespace Kanbang.Web.Logic.Security
{
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Security.Claims;
	using System.Security.Principal;
	using Coderful.Web.Identity;
	using UNOPS.Common.UserManagement.Domain;
	using UNOPS.Common.UserManagement.Managers;

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
				new Claim(ClaimTypes.NameIdentifier, user.Guid.ToString()),
				new Claim(ClaimTypes.GivenName, user.DisplayName),
				new Claim("UserManagementId", user.Id.ToString())
			};

			// TODO: add more claims.
			claims.Add(new Claim(ClaimTypes.UserData, "View-AdminDashboard"));
			claims.Add(new Claim(ClaimTypes.UserData, "View-Secret"));

			return claims;
		}

		private static User GetUser(IPrincipal userPrincipal)
		{
			WindowsIdentity windowsIdentity = userPrincipal.Identity as WindowsIdentity ?? WindowsIdentity.GetCurrent();

			Debug.Assert(windowsIdentity != null, "windowsIdentity != null");

			SecurityIdentifier user = windowsIdentity.User;

			return user == null ? null : UserManager.GetBySid(user.Value);
		}
	}
}