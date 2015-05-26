namespace Kanbang.Web.Logic.View
{
	using System.Web.Mvc;

	public abstract class MyWebViewPage<TModel> : WebViewPage
	{
		private class ViewBagFactory
		{
			public MyViewBag Create(dynamic viewBag)
			{
				return new MyViewBag(viewBag);
			}
		}
	}
}
