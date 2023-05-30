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

	// NOTE: Do not change the order in the lists until some improvements have been made.
	private static readonly string[] PRD_DB_URLS = { "./src/Infrastructure/Persistence/data.json", "./src/Infrastructure/Persistence/patterns.json" };
	private static readonly string[] TST_DB_URLS = { "../../../../test/Infrastructure/Persistence/test_data.json" }; // these are CORRECT paths.

	public static string[] GetDbUrls() => CURRENT_ENV switch
	{
		Env.PRD => PRD_DB_URLS,
		// Env.ACC => ACC_DB_URLS, // TODO
		Env.TST => TST_DB_URLS,
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

	public static string[] GetPrdDbUrls()
	{
		return PRD_DB_URLS;
	}

	public static string[] GetTstDbUrls()
	{
		return TST_DB_URLS;
	}
}