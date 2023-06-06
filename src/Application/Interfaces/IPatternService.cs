using Domain.DTO;

namespace Application.Interfaces;

public interface IPatternService
{
	public Task<GameDTO> PostPattern(GameDTO pattern);
	public bool DeletePattern(GameDTO pattern);
	public Task<GameDTO?> GetPattern(string id);
	public Task<GameDTO[]?> GetPatterns();
	public Task<GameDTO> PutPattern(GameDTO pattern);
	public Task<GameDTO> UpdatePattern(GameDTO pattern);
}