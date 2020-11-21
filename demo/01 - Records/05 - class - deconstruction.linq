<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	var p = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
	
	var (first, last) = p;
}

public class Person : IEquatable<Person>
{
	public string FirstName { get; init; }
	public string LastName { get; init; }

	public override bool Equals(object obj)
		=> Equals(obj as Person);

	public bool Equals(Person other)
		=> other is { } && (FirstName, LastName) == (other.FirstName, other.LastName);

	public override int GetHashCode()
		=> (FirstName, LastName).GetHashCode();

	public override string ToString()
		=> $"FirstName: '{FirstName}', LastName: '{LastName}'";

	public static bool operator ==(Person first, Person second)
		=> object.ReferenceEquals(first, second) || (first is { } && first.Equals(second));

	public static bool operator !=(Person first, Person second)
		=> !(first == second);
		
	public void Deconstruct(out String firstName, out string lastname)
		=> (firstName, lastname) = (FirstName, LastName);
}
