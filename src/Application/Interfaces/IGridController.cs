using Domain.DTO;

namespace Application.Interfaces;

public interface IGridController
{
	public Task<GameDTO> GetGrid(GameDTO game);
}