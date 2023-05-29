namespace UI.Console.Listeners;

// public class UserInputListener
// {
// 	private const int ONE_DAY_IN_SECONDS = 86400;

// 	private string userInput = String.Empty;

// 	public string? Listen(int seconds = ONE_DAY_IN_SECONDS)
// 	{
// 		var listenForInputThread = new Thread(listenForInput);

// 		listenForInputThread.Start();

// 		if (listenForInputThread.Join(TimeSpan.FromSeconds(seconds)))
// 		{
// 			System.Console.WriteLine("HERERER");
// 			return userInput;
// 		}
// 		else
// 		{
// 			System.Console.WriteLine("EMPTTYTYTYTYYTYTY");
// 			return String.Empty;
// 		}
// 	}

// 	public string GetUserInput()
// 	{
// 		System.Console.WriteLine("USER INPUT VALUEEEEEEEEEE: " + userInput);
// 		return this.userInput;
// 	}

// 	private void listenForInput()
// 	{
// 		this.userInput = System.Console.ReadLine();
// 		System.Console.WriteLine("USER INPUT TTTT : " + this.userInput);
// 	}
// }

public class UserInputListener
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
			input = System.Console.ReadLine();
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
		//throw new TimeoutException("User did not provide input within the timelimit.");
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