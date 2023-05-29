using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Utilities;

public class LocalStorage : ILocalStorage
{
	private Storage storage;

	public LocalStorage()
	{
		this.storage = new Storage();
	}

	public void SetLocalStorage(Storage storage)
	{
		this.storage = storage;
	}

	public Storage GetLocalStorage()
	{
		return this.storage;
	}
}