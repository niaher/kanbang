namespace Kanbang.Web.Logic.View
{
	using Kanbang.Web.Models;

	public class MyViewBag
	{
		private readonly dynamic viewBag;

		public MyViewBag(dynamic viewBag)
		{
			this.viewBag = viewBag;
		}

		public LayoutDetails LayoutDetails
		{
			get
			{
				return this.viewBag.LayoutDetails;
			}

			set
			{
				this.viewBag.LayoutDetails = value;
			}
		}
	}
}