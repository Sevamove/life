using Configuration.Enums;
using Configuration.Interfaces;

namespace Configuration;

public class Config : IConfig
{
	private const Env CURRENT_ENV = Env.PRD;

	// UI.

	private const string GAME_OF_LIFE_ASCII_ART = @"
 ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ███████╗    ██╗     ██╗███████╗███████╗
██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██╔════╝    ██║     ██║██╔════╝██╔════╝
██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║█████╗      ██║     ██║█████╗  █████╗  
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║██╔══╝      ██║     ██║██╔══╝  ██╔══╝  
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝██║         ███████╗██║██║     ███████╗
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝ ╚═╝         ╚══════╝╚═╝╚═╝     ╚══════╝
";

	private const int FRAMES_PER_SECOND = 1;
	private const bool SHOULD_CLEAR_CONSOLE_ON_EACH_FRAME = true;

	private const string LIVE_CELL_ICON = "🟦";
	private const string DEAD_CELL_ICON = "⬜️";

	// Infrastructure.

	private static readonly Dictionary<string, string> PRD_DB_URLS = new Dictionary<string, string>() {
		{ "games", "./src/Infrastructure/Persistence/games.json" },
		{ "patterns", "./src/Infrastructure/Persistence/patterns.json" }
	};
	private static readonly Dictionary<string, string> TST_DB_URLS = new Dictionary<string, string>() {
		{ "games", "../../../../test/Infrastructure/Persistence/test_games.json" },
		{ "patterns", "../../../../test/Infrastructure/Persistence/test_patterns.json" }
	};

	public static Dictionary<string, string> GetDbUrls() => CURRENT_ENV switch
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

	public static string GetGameOfLifeAsciiArt()
	{
		return GAME_OF_LIFE_ASCII_ART;
	}

	public static Dictionary<string, string> GetPrdDbUrls()
	{
		return PRD_DB_URLS;
	}

	public static Dictionary<string, string> GetTstDbUrls()
	{
		return TST_DB_URLS;
	}
}