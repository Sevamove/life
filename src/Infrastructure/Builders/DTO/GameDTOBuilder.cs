using Domain.DTO;
using Domain.Interfaces;
using Infrastructure.Entities;

namespace Infrastructure.Builders.DTO;

public class GameDTOBuilder
{
	public static GameDTO GetGameDTO(GameEntity gameEntity)
	{
		GridDTO gridDTO = GridDTOBuilder.GetGridDTO(gameEntity.Grid);

		return new GameDTO(gameEntity.Id, gameEntity.Name, gridDTO);
	}

	public static GameDTO GetGameDTO(IGame game)
	{
		GridDTO grid = GridDTOBuilder.GetGridDTO(game.Grid());

		return new GameDTO(game.Id(), game.Name(), grid);
	}

	public static GameDTO[] GetGameDTOs(List<GameEntity> gameEntities)
	{
		GameDTO[] gameDTOs = new GameDTO[gameEntities.Count];

		for (int i = 0; i < gameEntities.Count; i++)
		{
			gameDTOs[i] = GameDTOBuilder.GetGameDTO(gameEntities[i]);
		}

		return gameDTOs;
	}
	// V
	// 	public static GameDTO GetGameDTO(string gameId, string gameName, int areaWidth, int areaHeight, string[] cellsPositions)
	// 	{
	// 		// Cell positions 0-0 12-11 ...
	// 		GameDTO game = new GameDTO(gameId, gameName, new GridDTO(new AreaDTO(areaWidth, areaHeight), new CellDTO[] {

	// 		}));
	// 	}
}