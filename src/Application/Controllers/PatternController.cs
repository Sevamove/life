using Domain.DTO;
using Infrastructure.Repositories;
using Application.Interfaces;
using Application.Services;

namespace Application;

public class PatternController : IPatternController
{
	private readonly IPatternService patternService;

	public PatternController()
	{
		this.patternService = new PatternService(new PatternRepository());
	}

	public async Task<GameDTO> PostPattern(GameDTO pattern)
	{
		return await this.patternService.PostPattern(pattern);
	}

	public bool DeletePattern(GameDTO pattern)
	{
		return this.patternService.DeletePattern(pattern);
	}

	public async Task<GameDTO?> GetPattern(string id)
	{
		return await this.patternService.GetPattern(id);
	}

	public async Task<GameDTO[]?> GetPatterns()
	{
		return await this.patternService.GetPatterns();
	}

	public async Task<GameDTO> PutPattern(GameDTO pattern)
	{
		return await this.patternService.PutPattern(pattern);
	}
}