using SourceLink.Demo.Library.Models;

namespace SourceLink.Demo.Library.Repositories
{
	public interface IDemoRepository
	{
		DemoModel FetchDemoDetails();
	}
}
