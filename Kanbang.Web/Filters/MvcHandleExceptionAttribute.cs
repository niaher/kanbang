namespace Kanbang.Web.Filters
{
	using System.Security;
	using System.Web.Mvc;

	public class MvcHandleExceptionAttribute : IExceptionFilter
	{
		public void OnException(ExceptionContext filterContext)
		{
			if (filterContext.Exception is SecurityException)
			{
				filterContext.Result = new HttpUnauthorizedResult();
				filterContext.ExceptionHandled = true;
			}
		}
	}
}