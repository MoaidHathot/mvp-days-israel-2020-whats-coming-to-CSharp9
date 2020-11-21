<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	var p = new Person("Moaid", "Hathot")
	{
		MiddleName = "Jr.",
	};
	
	var p2 = p with { FirstName = "Haneen", MiddleName = null };
	var p3 = p with { };

	p.ToString().Dump();
	p2.ToString().Dump();
	p3.ToString().Dump();
}

public record Person(string FirstName, string LastName)
{
	public string MiddleName { get; init; }
}

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
