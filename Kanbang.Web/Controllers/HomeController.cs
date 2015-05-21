﻿namespace Kanbang.Web.Controllers
{
	using System.IdentityModel.Services;
	using System.Security.Permissions;
	using System.Web.Mvc;

	public partial class HomeController : Controller
	{
		public virtual ActionResult Index()
		{
			return this.View();
		}

		[ClaimsPrincipalPermission(SecurityAction.Demand, Operation = "View", Resource = "AdminDashboard")]
		public virtual ActionResult Admin()
		{
			return this.View();
		}
	}
}