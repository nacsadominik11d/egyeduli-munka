using egyeduli;

List<Termek> osszes = new List<Termek>();
Console.WriteLine("=== Raktárkészlet Rögzítése ===");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}. termék adatai");
    Termek ujTermek = new Termek();
    Console.WriteLine("\tNév: ");
    ujTermek.Nev = Console.ReadLine();
    Console.Write("\tEgységár (Ft): ");
    ujTermek.Ar = int.Parse(Console.ReadLine());
    Console.Write("\tRaktárkészlet (db): ");
    ujTermek.Mennyiseg = int.Parse(Console.ReadLine());
    
    osszes.Add(ujTermek);

}

Console.WriteLine(osszes.Count);

