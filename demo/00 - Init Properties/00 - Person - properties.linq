<Query Kind="Program" />

void Main()
{
	var p = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};

	p.Dump();
}

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}
