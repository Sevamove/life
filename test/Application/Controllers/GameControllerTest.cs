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
		// Arrange.

		IGame gameMock = new GameMock("123");
		GameDTO gameDTO = GameDTOBuilder.GetGameDTO(gameMock);

		// Act.

		GameDTO expectedGame = await this.gameController.CreateNewGame(gameDTO);

		// Assert.

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

	[Theory]
	[InlineData("1", "My Game 1")]
	[InlineData("5712&%$%&#   afl", "我的游戏")]
	public async void LoadGame_ReturnsGameDTO(string actualGameId, string actualGameName)
	{
		// Arrange.

		await this.clearTestDb();
		await this.populateTestDbWithDummyData(actualGameId, actualGameName);

		// Act.

		GameDTO? expectedGame = await this.gameController.LoadGame(actualGameId);
		string expectedGameId = expectedGame.Id;
		string expectedGameName = expectedGame.Name;

		// Assert.

		Assert.True(expectedGame != null);
		Assert.Equal(expectedGameId, actualGameId);
		Assert.Equal(expectedGameName, actualGameName);
	}

	private async Task<bool> populateTestDbWithDummyData()
	{
		return await this.populateTestDbWithDummyData("123", "My Game 123");
	}

	private async Task<bool> populateTestDbWithDummyData(string gameId, string gameName)
	{
		IGame gameMock = new GameMock(gameId, gameName);
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