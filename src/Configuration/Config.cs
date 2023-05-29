using Configuration.Enums;
using Configuration.Interfaces;

namespace Configuration;

public class Config : IConfig
{
	private const Env CURRENT_ENV = Env.PRD;

	// UI.
	private const int FRAMES_PER_SECOND = 1;
	private const bool SHOULD_CLEAR_CONSOLE_ON_EACH_FRAME = true;

	private const string LIVE_CELL_ICON = "🟦";
	private const string DEAD_CELL_ICON = "⬜️";

	// Infrastructure.

	private const string PRD_DB_URL = "./src/Infrastructure/DB/data.json";
	private const string TST_DB_URL = "../../../../test/Infrastructure/DB/test_data.json"; // CORRECT
																						   // private const string TST_DB_URL = "../../../../src/Infrastructure/DB/data.json";

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

	public static int GetScreenDelay()
	{
		int oneSecondInMiliseconds = 1000;

		return oneSecondInMiliseconds / FRAMES_PER_SECOND;
	}

	public static bool ShouldClearConsole()
	{
		return SHOULD_CLEAR_CONSOLE_ON_EACH_FRAME;
	}

	public static string GetLiveCellIcon()
	{
		return LIVE_CELL_ICON;
	}

	public static string GetDeadCellIcon()
	{
		return DEAD_CELL_ICON;
	}

	public static string GetPrdDbUrl()
	{
		return PRD_DB_URL;
	}

	public static string GetTstDbUrl()
	{
		return TST_DB_URL;
	}
}