namespace Kanbang.Web.Logic.Security
{
	using System.Security.Claims;

	public static class AppUser
	{
		public static string DisplayName
		{
			get
			{
				return ClaimsPrincipal.Current.FindFirst(System.IdentityModel.Claims.ClaimTypes.GivenName).Value;
			}
		}

		public static int Id
		{
			get
			{
				return int.Parse(ClaimsPrincipal.Current.FindFirst("UserManagementId").Value);
			}
		}
	}
}