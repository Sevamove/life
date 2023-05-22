using Infrastructure.Entities;

namespace Infrastructure.DTO.Builders;

public class GameDTOBuilder
{
	public static GameDTO GetGameDTO(GameEntity gameEntity)
	{
		GridDTO gridDTO = GridDTOBuilder.GetGridDTO(gameEntity.Grid);

		return new GameDTO(gameEntity.Id, gameEntity.Name, gridDTO);
	}
}