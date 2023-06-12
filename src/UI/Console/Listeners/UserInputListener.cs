namespace UI.Console.Listeners;

public static class UserInputListener
{
	private static Thread inputThread;
	private static AutoResetEvent getInput, gotInput;
	private static string input;

	static UserInputListener()
	{
		getInput = new AutoResetEvent(false);
		gotInput = new AutoResetEvent(false);
		inputThread = new Thread(reader);
		inputThread.IsBackground = true;
		inputThread.Start();
	}

	private static void reader()
	{
		while (true)
		{
			getInput.WaitOne();

			System.Console.Write("\n" + "> ");

			input = System.Console.ReadLine();

			System.Console.WriteLine();

			gotInput.Set();
		}
	}

	// omit the parameter to read a line without a timeout
	public static string Listen(int timeOutMillisecs = Timeout.Infinite)
	{
		getInput.Set();
		bool success = gotInput.WaitOne(timeOutMillisecs);
		if (success)
			return input;
		else
			return String.Empty;
	}

	public static bool TryReadLine(out string line, int timeOutMillisecs = Timeout.Infinite)
	{
		getInput.Set();
		bool success = gotInput.WaitOne(timeOutMillisecs);
		if (success)
			line = input;
		else
			line = null;
		return success;
	}
}