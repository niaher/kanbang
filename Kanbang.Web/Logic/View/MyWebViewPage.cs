namespace Kanbang.Web.Logic.View
{
	using Coderful.Web.Mvc;

	public abstract class MyWebViewPage<TModel> : CoderfulWebViewPage<TModel, MyViewBag>
	{
		protected MyWebViewPage()
			: base(new ViewBagFactory())
		{
		}

		private class ViewBagFactory : IViewBagFactory<MyViewBag>
		{
			public MyViewBag Create(dynamic viewBag)
			{
				return new MyViewBag(viewBag);
			}
		}
	}
}
