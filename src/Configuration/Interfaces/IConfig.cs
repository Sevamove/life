using Configuration.Enums;

namespace Configuration.Interfaces;

public interface IConfig
{
	static abstract Env GetEnv();
	static abstract int GetScreenDelay();
	static abstract bool ShouldClearConsole();
	static abstract string GetDbUrl();
	static abstract string GetTstDbUrl();
	static abstract string GetPrdDbUrl();
}