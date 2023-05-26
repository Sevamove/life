using Configuration.Enums;
using Configuration.Interfaces;

namespace Configuration;

public class Config : IConfig
{
	private const Env CURRENT_ENV = Env.PRD;

	private const string PRD_DB_URL = "./src/Infrastructure/DB/data.json";
	private const string TST_DB_URL = "../../../../test/Infrastructure/DB/test_data.json";

	private const string LIVE_CELL_ICON = "🟦";
	private const string DEAD_CELL_ICON = "⬜️";

	public static string GetDbUrl() => CURRENT_ENV switch
	{
		Env.PRD => PRD_DB_URL,
		Env.TST => TST_DB_URL,
		_ => throw new ArgumentOutOfRangeException()
	};

	public static Env GetEnv()
	{
		return CURRENT_ENV;
	}

	public static string GetPrdDbUrl()
	{
		return PRD_DB_URL;
	}

	public static string GetTstDbUrl()
	{
		return TST_DB_URL;
	}

	public static string GetLiveCellIcon()
	{
		return LIVE_CELL_ICON;
	}

	public static string GetDeadCellIcon()
	{
		return DEAD_CELL_ICON;
	}
}