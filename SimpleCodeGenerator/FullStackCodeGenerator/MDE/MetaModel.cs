namespace SimpleCodeGenerator;

public class Project
{
	public string Name { get; set; }
	public List<Entity> Entities { get; set; }
}

public class Entity
{
	public string Name { get; set; }
	public List<Attribute> Attributes { get; set; }
}

public class Attribute
{
	public string Name { get; set; }
	public string Type { get; set; }
}