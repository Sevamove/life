using Infrastructure.DTO;

namespace Infrastructure.Entities.Builders;

public class GameEntityBuilder
{
	public static GameEntity GetGameEntity(GameDTO gameDTO)
	{
		return new GameEntity
		{
			Id = gameDTO.Id,
			Name = gameDTO.Name,
			Grid = GridEntityBuilder.GetGridEntity(gameDTO)
		};
	}
}