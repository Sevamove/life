using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Utilities;

public class ComponentStorage : IComponentStorage
{
	private Storage storage;

	public ComponentStorage()
	{
		this.storage = new Storage();
	}

	public void ResetComponentStorage()
	{
		this.storage.IsAnchorTriggered = false;
	}

	public void SetComponentStorage(Storage storage)
	{
		this.storage = storage;
	}

	public Storage GetComponentStorage()
	{
		return this.storage;
	}
}