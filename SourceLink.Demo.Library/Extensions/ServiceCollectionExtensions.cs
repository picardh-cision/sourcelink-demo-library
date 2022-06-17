using System;
using Microsoft.Extensions.DependencyInjection;
using SourceLink.Demo.Library.Models.Configuration;
using SourceLink.Demo.Library.Repositories;
using SourceLink.Demo.Library.Services;

namespace SourceLink.Demo.Library.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection SetupDemo(this IServiceCollection services,
			Action<DemoRepositoryConfig> configDelegate)
		{
			return services
				.AddSingleton<IDemoRepository, DemoRepository>()
				.AddSingleton<IDemoService, DemoService>()
				.Configure<DemoRepositoryConfig>(c => configDelegate?.Invoke(c));
		}
	}
}
