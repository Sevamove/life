using Application.Interfaces;
using Domain.DTO;
using Infrastructure.Builders.DTO;
using Infrastructure.Builders.Entities;
using Infrastructure.Entities;
using Infrastructure.Interfaces;

namespace Application.Services;

public class PatternService : IPatternService
{
	private readonly IRepository<GameEntity> PatternRepository;

	public PatternService(IRepository<GameEntity> repository)
	{
		this.PatternRepository = repository;
	}

	public async Task<GameDTO> PostPattern(GameDTO Pattern)
	{
		List<GameEntity> patternEntities = new List<GameEntity>() {
			GameEntityBuilder.GetGameEntity(Pattern)};

		List<GameEntity> savedPatternEntities = await this.PatternRepository.SaveAllAsync(patternEntities);

		return GameDTOBuilder.GetGameDTO(savedPatternEntities.ToArray()[0]);
	}

	public bool DeletePattern(GameDTO Pattern)
	{
		throw new NotImplementedException();
	}

	public async Task<GameDTO?> GetPattern(string id)
	{
		GameEntity? pattern = await this.PatternRepository.FindByIdAsync(id);

		if (pattern != null)
		{
			return GameDTOBuilder.GetGameDTO(pattern);
		}

		return null;
	}

	public async Task<GameDTO[]?> GetPatterns()
	{
		List<GameEntity>? data = await this.PatternRepository.FindAllAsync();

		if (data != null)
		{
			return GameDTOBuilder.GetGameDTOs(data);
		}

		return null;
	}

	public Task<GameDTO> PutPattern(GameDTO pattern)
	{
		throw new NotImplementedException();
	}

	public Task<GameDTO> UpdatePattern(GameDTO pattern)
	{
		throw new NotImplementedException();
	}
}