namespace UI.Console.Utilities;

public class ConsolePrompt
{
	public static async Task<string> ReadUserInputWithTimeout(TimeSpan timeout)
	{
		var userInputTask = Task.Run(() => System.Console.ReadLine());
		var timeoutTask = Task.Delay(timeout);

		if (await Task.WhenAny(userInputTask, timeoutTask) == userInputTask)
		{
			return await userInputTask;
		}
		else
		{
			return null;
		}
	}
}