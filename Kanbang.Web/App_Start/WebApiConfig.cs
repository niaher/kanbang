namespace Kanbang.Web
{
	using System.Net.Http.Headers;
	using System.Web.Http;
	using System.Web.Http.OData.Extensions;
	using Kanbang.Web.Filters;

	public class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.AddODataQueryFilter();

			config.Routes.MapHttpRoute(
				name: "ApiById",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional },
				constraints: new { id = @"^[0-9]+$" });

			config.Routes.MapHttpRoute(
				name: "ApiByAction",
				routeTemplate: "api/{controller}/{action}",
				defaults: new { action = "Get" });

			config.Routes.MapHttpRoute(
				name: "ApiByActionAndId",
				routeTemplate: "api/{controller}/{action}/{id}",
				defaults: new { action = "Get", id = RouteParameter.Optional },
				constraints: new { id = @"^[0-9]+$" });

			config.Filters.Add(new WebApiHandleExceptionAttribute());

			// Return JSON by default (instead of XML).
			config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
		}
	}
}