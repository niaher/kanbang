namespace Kanbang.Web
{
	using System;
	using System.Globalization;
	using System.Security.Claims;
	using System.Threading;
	using System.Web;
	using System.Web.Helpers;
	using System.Web.Http;
	using System.Web.Mvc;
	using System.Web.Optimization;

	public class Global : HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			AreaRegistration.RegisterAllAreas();

			BundleConfig.RegisterBundles(BundleTable.Bundles);
			WebApiConfig.Register(GlobalConfiguration.Configuration);

			SetupCulture();

			AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
		}

		private static void SetupCulture()
		{
			var newCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
			newCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
			newCulture.DateTimeFormat.ShortDatePattern = "dd MMM yyyy";
			newCulture.DateTimeFormat.DateSeparator = "-";
			newCulture.NumberFormat.NumberDecimalDigits = 2;
			newCulture.NumberFormat.CurrencyDecimalDigits = 2;
			newCulture.NumberFormat.CurrencyNegativePattern = 1;
			newCulture.NumberFormat.CurrencySymbol = string.Empty;
			Thread.CurrentThread.CurrentCulture = newCulture;
		}
	}
}