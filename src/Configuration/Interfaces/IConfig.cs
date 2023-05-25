using Configuration.Enums;

namespace Configuration.Interfaces;

public interface IConfig
{
	static abstract string GetDbUrl();
	static abstract string GetTstDbUrl();
	static abstract string GetPrdDbUrl();
	static abstract Env GetEnv();
}