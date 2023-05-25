using Application;
using Application.Interfaces;
using Configuration;
using Domain.DTO;
using Domain.Interfaces;
using Infrastructure.Builders.DTO;
using Test.Mocks;

namespace Test.Application.Controllers;

public class GameControllerTest
{
	private readonly IGameController gameController;

	public GameControllerTest()
	{
		this.gameController = new GameController();
	}

	[Fact]
	public async void CreateNewGame_ReturnsGameDTO()
	{
		IGame gameMock = new GameMock("123");
		GameDTO gameDTO = GameDTOBuilder.GetGameDTO(gameMock);

		GameDTO expectedGame = await this.gameController.CreateNewGame(gameDTO);

		Assert.True(expectedGame.Id == gameMock.Id());
		Assert.True(expectedGame.Name == gameMock.Name());
		Assert.True(expectedGame.Grid != null);
	}

	[Fact]
	public async void LoadGames_ReturnsGameDTOs()
	{
		// Arrange.

		await this.clearTestDb();
		await this.populateTestDbWithDummyData();

		// Act.

		GameDTO[]? expectedGames = await this.gameController.LoadGames();

		// Assert.

		Assert.True(expectedGames != null);
		Assert.True(expectedGames.Length > 0);
	}

	private async Task<bool> populateTestDbWithDummyData()
	{
		IGame gameMock = new GameMock("123", "My Game 123");
		GameDTO gameDTO = GameDTOBuilder.GetGameDTO(gameMock);

		GameDTO expectedGame = await this.gameController.CreateNewGame(gameDTO);

		return true;
	}

	private async Task<bool> clearTestDb()
	{
		await File.WriteAllTextAsync(Config.GetTstDbUrl(), String.Empty);

		return true;
	}
}