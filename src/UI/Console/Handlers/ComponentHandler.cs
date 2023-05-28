using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Handlers;

public class ComponentHandler
{
	// public static async Task<ComponentResult> Handle(ComponentId componentId, IComponent[] components)
	// {
	// 	foreach (var component in components)
	// 	{
	// 		if (component.GetComponentId() == componentId)
	// 		{
	// 			return await component.Execute(componentId);
	// 		}

	// 		var childComponents = component.GetChildComponents();

	// 		if (childComponents.Length > 0)
	// 		{
	// 			var result = await Handle(componentId, childComponents);

	// 			if (result != null)
	// 			{
	// 				return result;
	// 			}
	// 		}
	// 	}

	// 	// return null;
	// 	throw new Exception("Exception occurred.");
	// }
}