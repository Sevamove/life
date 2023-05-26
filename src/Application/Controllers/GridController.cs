using Domain.DTO;
using Application.Interfaces;
using Application.Services;

namespace Application;

public class GridController : IGridController
{
	private readonly IGridService gridService;

	public GridController()
	{
		this.gridService = new GridService();
	}

	public async Task<GameDTO> GetGrid(GameDTO game)
	{
		return this.gridService.GetGrid(game);
	}
}