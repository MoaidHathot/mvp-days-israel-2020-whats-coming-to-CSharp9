<Query Kind="Program" />

void Main()
{
	var p = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
	
	p.GetType().GetProperties()[0].SetMethod.ReturnParameter.GetRequiredCustomModifiers().Dump();
}

public class Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
}
