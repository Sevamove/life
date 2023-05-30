using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface ILocalStorage
{
	public void SetLocalStorage(Storage storage);
	public Storage GetLocalStorage();
}