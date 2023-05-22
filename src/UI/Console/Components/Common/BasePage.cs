using Application;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BasePage : IPage
{
	public readonly Game Game;
	public readonly BaseComponent[] ChildComponents;

	public BasePage(Game game, BaseComponent[] childComponents)
	{
		this.Game = game;
		this.ChildComponents = childComponents;
	}

	public virtual void Render()
	{
		foreach (var childComponent in this.ChildComponents)
		{
			childComponent.Render();
		}
	}
}