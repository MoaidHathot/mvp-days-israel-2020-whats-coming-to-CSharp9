<Query Kind="Program" />

void Main()
{
	var p = new Person("Moaid", "Hathot");
	
	p.ToString().Dump();
}

public record Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
	
	public Person(string firstName, string lastName)
		=> (FirstName, LastName) = (firstName, lastName);
}

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
