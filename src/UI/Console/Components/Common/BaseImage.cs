using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseImage : BaseComponent, IImage
{
	internal readonly string src;
	internal readonly string alt;

	public BaseImage(ComponentId componentId, string src, string alt, IComponent[] childComponents) : base(componentId, ElementId.Img, childComponents)
	{
		this.src = src;
		this.alt = alt;
	}

	public override void Render()
	{
		System.Console.WriteLine(this.src);
	}
}