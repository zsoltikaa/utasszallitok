using utasszallitokCLI;

List<Repulogep> repulogepek = [];
var sebessegKategoriak = new List<string> { "Alacsony sebességű", "Szubszonikus", "Transzszonikus", "Szuperszonikus" };

const string path = "C:\\Users\\zsolt\\Source\\Repos\\utasszallitok\\utasszallitok.txt";
const string outputPath = "C:\\Users\\zsolt\\Source\\Repos\\utasszallitok\\utasszallitok_new.txt";

using (StreamReader reader = new StreamReader(path))
{
    
    _ = reader.ReadLine();

    while (!reader.EndOfStream)
    {
        repulogepek.Add(new(reader.ReadLine()));
    }

}

Console.WriteLine($"4. feladat: adatsorok szama: {repulogepek.Count}");

Console.WriteLine($"5. feladat: Boeing tipusok szama: {repulogepek.Where(r => r.Tipus.ToLower().StartsWith("boeing")).Count()}");

// 6. feladat
Repulogep legtobbUtasGep = null;
int maxUtas = 0;

foreach (var r in repulogepek)
{
    int utasSzam = r.Utas.Contains('-')
        ? int.Parse(r.Utas.Split('-')[1])
        : int.Parse(r.Utas);

    if (utasSzam > maxUtas)
    {
        maxUtas = utasSzam;
        legtobbUtasGep = r;
    }
}

if (legtobbUtasGep != null)
{
    Console.WriteLine($"6. feladat: a legtobb utast szallito repulogep\n\tTipus: {legtobbUtasGep.Tipus}\n\tElso felszallas: {legtobbUtasGep.Ev}\n\tUtasok szama: {legtobbUtasGep.Utas}\n\tSzemelyzet: {legtobbUtasGep.Szemelyzet}\n\tUtazosebesseg: {legtobbUtasGep.Utazosebesseg}");
}

// 7. feladat
var hasznaltKategoriak = repulogepek
    .Select(r => new Sebessegkategoria(r.Utazosebesseg).Kategorianev)
    .Distinct()
    .ToList();

var hianyzoKategoriak = sebessegKategoriak
    .Where(kategoria => !hasznaltKategoriak.Contains(kategoria))
    .ToList();

if (hianyzoKategoriak.Count == 0)
{
    Console.WriteLine("7. feladat: Minden sebességkategóriából van repülőgép.");
}
else
{
    Console.WriteLine($"7. feladat: ");
    Console.WriteLine($"\t{string.Join(" ", hianyzoKategoriak)}");
}

// 8. feladat
using (StreamWriter writer = new StreamWriter(outputPath))
{
    writer.WriteLine("típus;év;utas;személyzet;utazósebesség;felszállótömeg;fesztáv");

    foreach (var repulogep in repulogepek)
    {
        string utas = repulogep.Utas.Split('-').Last();
        string szemelyzet = repulogep.Szemelyzet.Split('-').Last();

        int felszallotomegTonnaval = (int)Math.Round(repulogep.Felszallotomeg / 1000.0);
        int fesztavLabban = (int)Math.Round(repulogep.Fesztav * 3.2808);

        writer.WriteLine($"{repulogep.Tipus};{repulogep.Ev};{utas};{szemelyzet};{repulogep.Utazosebesseg};{felszallotomegTonnaval};{fesztavLabban}");
    }
}