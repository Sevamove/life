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
	private readonly IRestApi restApi;

	public GameControllerTest()
	{
		this.restApi = new RestApi();
	}

	[Fact]
	public async void PostGame_ReturnsGameDTO()
	{
		// Arrange.

		IGame gameMock = new GameMock("123");
		GameDTO gameDTO = GameDTOBuilder.GetGameDTO(gameMock);

		// Act.

		GameDTO expectedGame = await this.restApi.PostGame(gameDTO);

		// Assert.

		Assert.True(expectedGame.Id == gameMock.Id());
		Assert.True(expectedGame.Name == gameMock.Name());
		Assert.True(expectedGame.Grid != null);
	}

	[Fact]
	public async void GetGames_ReturnsGameDTOs()
	{
		// Arrange.

		await this.clearTestDb();
		await this.populateTestDbWithDummyData();

		// Act.

		GameDTO[]? expectedGames = await this.restApi.GetGames();

		// Assert.

		Assert.True(expectedGames != null);
		Assert.True(expectedGames.Length > 0);
	}

	[Theory]
	[InlineData("1", "My Game 1")]
	[InlineData("5712&%$%&#   afl", "我的游戏")]
	public async void GetGame_ReturnsGameDTO(string actualGameId, string actualGameName)
	{
		// Arrange.

		await this.clearTestDb();
		await this.populateTestDbWithDummyData(actualGameId, actualGameName);

		// Act.

		GameDTO? expectedGame = await this.restApi.GetGame(actualGameId);
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

		GameDTO expectedGame = await this.restApi.PostGame(gameDTO);

		return true;
	}

	private async Task<bool> clearTestDb()
	{
		await File.WriteAllTextAsync(Config.GetTstDbUrls()["games"], String.Empty); // TODO: Let the user choose where to write the data.

		return true;
	}
}