using Configuration;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Image;

namespace UI.Console.Components.Images;

public class GameOfLifeLogoImage : BaseImage
{
	public GameOfLifeLogoImage() :
		base(
			ComponentId.GameOfLifeLogoImage,
			Config.GetGameOfLifeAsciiArt(),
			"Game of Life logo image",
			ImageChildrenFactory.GetGameOfLifeLogoImageChildren())
	{
	}
}