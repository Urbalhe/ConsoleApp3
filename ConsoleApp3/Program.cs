namespace ConsoleApp3
{
	public class Sorkerdes
	{
		public string Kerdes { get; set; }
		public List<string> Valaszok { get; set; }

		public string HelyesValasz { get; set; }
		

	}

	public Sorkerdes (string kerdes, List<string> valaszok, string helyesValasz)
	{
		Kerdes = kerdes;
		Valaszok = valaszok;
		HelyesValasz = helyesValasz;
	}
}

public class Kerdes
{
	public string Kerdes { get; set; }
	public List<string> Valaszok { get; set; }

	public string HelyesValasz { get; set; }

	public Kerdes(string kerdes, List<string> valaszok, string helyesValasz)
	{
		Kerdes = kerdes;
		Valaszok = valaszok;
		HelyesValasz = helyesValasz;
	}
}

public class Kerdesek
{
	public <list>Kerdesek { get; set; }
}
