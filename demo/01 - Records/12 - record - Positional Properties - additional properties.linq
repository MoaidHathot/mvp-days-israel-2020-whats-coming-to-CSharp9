<Query Kind="Program" />

void Main()
{
	var p = new Person("Moaid", "Hathot")
	{
		MiddleName = "Jr.",
	};

	p.ToString().Dump();
}

public record Person(string FirstName, string LastName)
{
	public string MiddleName { get; init; }
}

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
