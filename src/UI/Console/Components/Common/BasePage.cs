using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BasePage : BaseComponent, IPage
{
	public BasePage(ComponentId componentId, IComponent[] childComponents) : base(componentId, ElementId.Main, childComponents)
	{
	}

	public override void Render()
	{
		this.updateComponentStorages();
		this.clearConsole();

		this.componentHelper.Render(ComponentId.MainHeader);
		this.componentHelper.Render(ElementId.Nav);
	}
}