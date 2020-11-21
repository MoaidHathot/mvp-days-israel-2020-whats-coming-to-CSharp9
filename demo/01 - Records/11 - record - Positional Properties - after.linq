<Query Kind="Program" />

void Main()
{
	var p = new Person("Moaid", "Hathot");
	
	p.ToString().Dump();
}

public record Person(string FirstName, string LastName);

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
