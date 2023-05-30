using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Interfaces;
using UI.Console.Types;
using UI.Console.Utilities;

namespace UI.Console.Application;

public class App
{
	private readonly IPage[] pages;
	private readonly ILocalStorage localStorage;

	public App()
	{
		this.pages = PageFactory.GetAllPages();
		this.localStorage = new LocalStorage();
	}

	public App(IPage[] pages, ILocalStorage localStorage)
	{
		this.pages = pages;
		this.localStorage = localStorage;
	}

	public async Task Launch()
	{
		while (true)
		{
			if (this.localStorage.GetLocalStorage().Router.Pull() == Page.Home)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.HomePage, this.pages);
				pageRef.SetComponentStorage(this.localStorage.GetLocalStorage());

				await pageRef.LoadResourceDependencies();
				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetLocalStorage(pageResult.Storage);

				if (this.localStorage.GetLocalStorage().IsGameQuit)
				{
					break;
				}
			}

			if (this.localStorage.GetLocalStorage().Router.Pull() == Page.Games)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.GamesPage, this.pages);
				pageRef.SetComponentStorage(this.localStorage.GetLocalStorage());

				await pageRef.LoadResourceDependencies();
				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetLocalStorage(pageResult.Storage);

				if (this.localStorage.GetLocalStorage().IsGameQuit)
				{
					break;
				}
			}

			if (this.localStorage.GetLocalStorage().Router.Pull() == Page.GameNew)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.GameNewPage, this.pages);
				pageRef.SetComponentStorage(this.localStorage.GetLocalStorage());

				await pageRef.LoadResourceDependencies();
				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetLocalStorage(pageResult.Storage);

				if (this.localStorage.GetLocalStorage().IsGameQuit)
				{
					break;
				}
			}

			if (this.localStorage.GetLocalStorage().Router.Pull() == Page.Playground)
			{
				IPage? pageRef = Searcher.GetPage(ComponentId.PlaygroundPage, this.pages);
				pageRef.SetComponentStorage(this.localStorage.GetLocalStorage());

				await pageRef.LoadResourceDependencies();
				pageRef.Render();
				ComponentResult pageResult = await pageRef.Execute();

				this.localStorage.SetLocalStorage(pageResult.Storage);

				if (this.localStorage.GetLocalStorage().IsGameQuit)
				{
					break;
				}
			}
		}
	}
}