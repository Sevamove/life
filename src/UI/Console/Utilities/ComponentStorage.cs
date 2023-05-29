using UI.Console.Enums;
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
		// TODO: improve and refactor.
		Router router = new Router();
		router.Push(Page.NotFound);

		Storage newStorage = new Storage { Router = router };
		this.storage = newStorage;
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