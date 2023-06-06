namespace Domain.Exceptions;

public class InvalidNeighborsAmountException : Exception
{
	public InvalidNeighborsAmountException() : base("Provided invalid amount of neighbors") { }
}