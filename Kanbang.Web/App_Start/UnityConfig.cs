using Kanbang.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(UnityConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(UnityConfig), "Shutdown")]

namespace Kanbang.Web
{
	using System;
	using System.Linq;
	using System.Web.Http;
	using System.Web.Mvc;
	using Microsoft.Practices.Unity;
	using Microsoft.Practices.Unity.Mvc;
	using MvcUnityDependencyResolver = Microsoft.Practices.Unity.Mvc.UnityDependencyResolver;
	using WebApiUnityDependencyResolver = Unity.WebApi.UnityDependencyResolver;

	/// <summary>
	/// Specifies the Unity configuration for the main container.
	/// </summary>
	public class UnityConfig
	{
		private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(
			() =>
			{
				var container = new UnityContainer();
				RegisterTypes(container);
				return container;
			});

		public static IUnityContainer GetContainer()
		{
			return Container.Value;
		}

		public static void Shutdown()
		{
			GetContainer().Dispose();
		}

		public static void Start()
		{
			var container = GetContainer();

			FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
			FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(container));

			DependencyResolver.SetResolver(new MvcUnityDependencyResolver(container));
			GlobalConfiguration.Configuration.DependencyResolver = new WebApiUnityDependencyResolver(container);

			Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
		}

		private static void RegisterTypes(IUnityContainer container)
		{
		}
	}
}