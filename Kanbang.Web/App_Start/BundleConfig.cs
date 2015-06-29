namespace Kanbang.Web
{
	using System.Web.Optimization;

	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/css/main")
				.Include("~/Styles/Bootstrap/less/bootstrap.css", new CssRewriteUrlTransform())
				.Include("~/Styles/FontAwesome/css/font-awesome.css", new CssRewriteUrlTransform())
				.Include("~/Styles/Main.css", new CssRewriteUrlTransform()));
		}
	}
}
