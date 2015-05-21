namespace Kanbang.Web.Logic.Security
{
	using System.Linq;
	using System.Security.Claims;

	public class Authorizor : ClaimsAuthorizationManager
	{
		public override bool CheckAccess(AuthorizationContext context)
		{
			string resource = context.Resource.First().Value;

			if (resource.StartsWith("http"))
			{
				return true;
			}

			string action = context.Action.First().Value;

			return context.Principal.HasClaim(ClaimTypes.UserData, action + "-" + resource);
		}
	}
}