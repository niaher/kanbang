namespace Kanbang.Web.Logic.Security
{
	using System.Security.Claims;
	using ClaimTypes = System.IdentityModel.Claims.ClaimTypes;

	public static class AppUser
	{
		public static string DisplayName
		{
			get
			{
				return ClaimsPrincipal.Current.FindFirst(ClaimTypes.GivenName).Value;
			}
		}

		public static int Id
		{
			get
			{
				return int.Parse(ClaimsPrincipal.Current.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);
			}
		}
	}
}