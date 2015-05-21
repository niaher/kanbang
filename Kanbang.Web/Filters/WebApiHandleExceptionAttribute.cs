namespace Kanbang.Web.Filters
{
	using System.Net;
	using System.Net.Http;
	using System.Security;
	using System.Web.Http.Filters;

	public class WebApiHandleExceptionAttribute : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext context)
		{
			if (context.Exception is SecurityException)
			{
				context.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
				context.Response.Content = new StringContent("Access denied.");
			}
		}
	}
}