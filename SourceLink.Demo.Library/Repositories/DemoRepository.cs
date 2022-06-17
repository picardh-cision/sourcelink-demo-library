using System;
using Microsoft.Extensions.Options;
using SourceLink.Demo.Library.Models;
using SourceLink.Demo.Library.Models.Configuration;

namespace SourceLink.Demo.Library.Repositories
{
	public class DemoRepository : IDemoRepository
	{
		private readonly DemoRepositoryConfig _config;

		public DemoRepository(IOptions<DemoRepositoryConfig> configOptions)
		{
			_config = configOptions.Value;
		}

		public DemoModel FetchDemoDetails()
			=> new DemoModel
			{
				Issuer       = _config.Client,
				LastModified = DateTime.UtcNow
			};
		
	}
}
