namespace Kanbang.Web.Controllers.Api
{
	using System.IdentityModel.Services;
	using System.Security.Permissions;
	using System.Web.Http;

	public class DataController : ApiController
	{
		[HttpGet]
		public string Get(int? id)
		{
			return "data-" + id;
		}

		[HttpGet]
		[ClaimsPrincipalPermission(SecurityAction.Demand, Operation = "View", Resource = "Secret")]
		public string GetSecret(int? id)
		{
			return "secret-" + id;
		}
	}
}