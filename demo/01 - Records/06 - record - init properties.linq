<Query Kind="Program" />

void Main()
{
	var p = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
}

public record Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
}
