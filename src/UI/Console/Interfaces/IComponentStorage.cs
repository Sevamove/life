using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IComponentStorage
{
	public void SetComponentStorage(Storage storage);
	public void ResetComponentStorage();
}