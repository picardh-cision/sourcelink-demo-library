﻿using SourceLink.Demo.Library.Models;
using SourceLink.Demo.Library.Repositories;

namespace SourceLink.Demo.Library.Services
{
    public class DemoService : IDemoService
	{
		private readonly IDemoRepository _repository;

		public DemoService(IDemoRepository repository)
		{
			_repository = repository;
		}

		public DemoModel GetDemoContent()
		{
			const string CONTEXT = "DemoService";

			var result = _repository.FetchDemoDetails();
			result.Context = CONTEXT;

			return result;
		}
	}
}