// using Application;
// using Application.Interfaces;
// using Configuration;
// using Domain.DTO;
// using Domain.Interfaces;
// using Infrastructure.Builders.DTO;
// using Test.Mocks;
// using UI.Console.Application;
// using UI.Console.Builders;
// using UI.Console.Enums;
// using UI.Console.Utilities;

// namespace Test.Application.Controllers;

// public class GameNewPageTest
// {
// 	private readonly App app;

// 	public GameNewPageTest()
// 	{
// 		IRestApi restApi = new RestApi();

// 		this.app = new App(
// 			restApi,
// 			new Router(Page.Game_New),
// 			PagesBuilder.GetAllPages(restApi),
// 			new LocalStorage()
// 		);
// 	}

// 	[Fact]
// 	public async void Execute_ReturnsComponentResult()
// 	{
// 		this.app.Launch();
// 	}
// }