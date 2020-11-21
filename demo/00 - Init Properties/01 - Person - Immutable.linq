<Query Kind="Program" />

void Main()
{
	var p = new Person("Moaid", "Hathot");

	p.Dump();
}

public class Person
{
	public string FirstName { get; }
	public string LastName { get; }
	
	public Person(string firstName, string lastName)
		=> (FirstName, LastName) = (firstName, lastName);
}
