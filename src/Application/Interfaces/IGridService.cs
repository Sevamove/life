using Domain.DTO;

namespace Application.Interfaces;

public interface IGridService
{
	public GameDTO GetGrid(GameDTO game);
}