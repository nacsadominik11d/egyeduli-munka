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
    Console.WriteLine();
}

Console.WriteLine(osszes.Count);
//4.feladat
double teljesertek = 0;
double atlag = 0;
int osszdb = 0;
Console.WriteLine("Adatok feldolgozása...========================================");
Console.WriteLine("Rögzített termékek a raktárban:");
foreach (Termek t in osszes)
{
    teljesertek += t.Ar * t.Mennyiseg;
    osszdb += t.Mennyiseg;
    Console.WriteLine($"\t- {t.Nev}: {t.Ar} Ft/db ({t.Mennyiseg} db) -> Érték: {t.Ar * t.Mennyiseg} Ft");
}
atlag = teljesertek / osszdb;
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Raktár teljes értéke: {teljesertek} Ft");
Console.WriteLine($"Termékek átlagos egységára: {atlag:F0} Ft");
Console.WriteLine("========================================");

