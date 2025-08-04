using System;

class Produkt
{
	static void Main()
	{
	Djurinformation Djur = new Djurinformation();
	Djur.Namn = "Elefant";
	Djur.Vikt = 4000;
	
	Console.WriteLine ($"Djur:{Djur.Namn},Vikt:{Djur.Vikt} kg");
	}
}

