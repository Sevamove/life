using Configuration.Enums;

namespace Configuration.Interfaces;

public interface IConfig
{
	static abstract Env GetEnv();
	static abstract int GetScreenDelay();
	static abstract bool ShouldClearConsole();
	static abstract string[] GetDbUrls();
	static abstract string GetLiveCellIcon();
	static abstract string GetDeadCellIcon();
	static abstract string[] GetTstDbUrls();
	static abstract string[] GetPrdDbUrls();
}