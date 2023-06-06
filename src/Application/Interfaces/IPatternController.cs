using Domain.DTO;

namespace Application.Interfaces;

public interface IPatternController
{
	public Task<GameDTO> PostPattern(GameDTO pattern); // Creates a new pattern.
	public Task<GameDTO> PutPattern(GameDTO pattern); // Updates and saves the pattern.
	public Task<GameDTO?> GetPattern(string id); // Fetches a pattern of `id` from DB.
	public Task<GameDTO[]?> GetPatterns(); // Fetches all patterns from DB.
	public bool DeletePattern(GameDTO pattern); // Removes the pattern from DB.
}