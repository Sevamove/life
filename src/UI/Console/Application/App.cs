using Application;
using Application.Interfaces;
using UI.Console.Builders;
using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;
using UI.Console.Utilities;

namespace UI.Console.Application;

public class App
{
	private readonly IRestApi restApi;
	private readonly IRouter router;
	private readonly IPage[] pages;
	private readonly ILocalStorage localStorage;

	public App()
	{
		this.restApi = new RestApi();
		this.router = new Router(Page.Home);
		this.pages = PagesBuilder.GetAllPages(this.restApi);
		this.localStorage = new LocalStorage();
	}

	public App(IRestApi restApi, IRouter router, IPage[] pages, ILocalStorage localStorage)
	{
		this.restApi = restApi;
		this.router = router;
		this.pages = pages;
		this.localStorage = localStorage;
	}

	public async void Launch()
	{
		while (true)
		{
			if (this.router.GetCurrentPage() == Page.Home)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.HomePage, this.pages);

				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetStorage(pageResult);
				this.router.SetCurrentPage(pageResult.Page.GetValueOrDefault());
			}

			if (this.router.GetCurrentPage() == Page.Games)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.GamesPage, this.pages);

				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetStorage(pageResult);
				this.router.SetCurrentPage(pageResult.Page.GetValueOrDefault());
			}

			if (this.router.GetCurrentPage() == Page.Game_New)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.GameNewPage, this.pages);

				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetStorage(pageResult);
				this.router.SetCurrentPage(pageResult.Page.GetValueOrDefault());
			}

			if (this.router.GetCurrentPage() == Page.Playground)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.PlaygroundPage, this.pages);

				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetStorage(pageResult);
				this.router.SetCurrentPage(pageResult.Page.GetValueOrDefault());
			}
		}
	}
}