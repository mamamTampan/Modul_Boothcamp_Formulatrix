namespace BirdSpecies;

public class Bird
{
	private string _species;
	private string _weight;
	private string _color;
	// private string _food;
	// private string _walk;
	// private string _fly;
	
	
	public Bird(string species, string weight, string color)
	{
		_species = species;
		_weight = weight;
		_color = color;
		Console.WriteLine(_species + ", " + _weight + ", " + _color);
	}
	
	public Bird(string species)
	{
		if (species == "Penguin")
		{
			_species = species;
			_weight = "1100 grams";
			_color = "white";
		}
	}
	
	public string getWeight() //PascalCase GetWeight()
	{	
		return _weight;
	}
	
	public string getSpecies()
	{
		return _species;
	}
	
	public string getColor()
	{
		return _color;
	}
}
