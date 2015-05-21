namespace Kanbang.Web
{
	using System.Web.Optimization;

	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/js/libs/angular").Include(
				"~/Scripts/Libs/Angular/angular.js",
				"~/Scripts/Libs/Angular/angular-route.js",
				"~/Scripts/Libs/Angular/angular-animate.js",
				"~/Scripts/Libs/ui-bootstrap/ui-bootstrap-0.11.0.js"));

			bundles.Add(new ScriptBundle("~/js/app").Include(
				"~/Scripts/App/_App.js"));

			bundles.Add(new StyleBundle("~/css/main")
				.Include("~/Styles/Bootstrap/less/bootstrap.css", new CssRewriteUrlTransform())
				.Include("~/Styles/FontAwesome/css/font-awesome.css", new CssRewriteUrlTransform())
				.Include("~/Styles/Main.css", new CssRewriteUrlTransform()));
		}
	}
}
