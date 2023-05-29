namespace UI.Console.Types;

public class ComponentResult : ICloneable
{
	public Storage Storage { get; init; } = new Storage();

	public object Clone()
	{
		return new ComponentResult
		{
			Storage = this.Storage
		};
	}
}