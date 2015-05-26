namespace Kanbang.Web.Logic.View
{
	using System.Web.Mvc;

	public abstract class MyWebViewPage<TModel> : WebViewPage<TModel>
	{
		protected MyWebViewPage()
		{
			this.StrongViewBag = new MyViewBag(this.ViewBag);
		}

		public MyViewBag StrongViewBag { get; set; }
	}
}
