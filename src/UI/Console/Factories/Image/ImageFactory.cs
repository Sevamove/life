using UI.Console.Components.Images;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Image;

public static class ImageFactory
{
	public static IComponent[] GetAllImages()
	{
		return new IComponent[] {
			GetGameOfLifeLogoImage()
		};
	}

	public static IComponent GetGameOfLifeLogoImage()
	{
		return new GameOfLifeLogoImage();
	}
}