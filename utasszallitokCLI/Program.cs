using utasszallitokCLI;

List<Repulogep> repulogepek = [];

const string path = "H:\\c#\\forms apps\\utasszallitokCLI\\utasszallitok.txt";
const string outputPath = "H:\\c#\\forms apps\\utasszallitokCLI\\";

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

Console.WriteLine("6. feladat: ");

Console.WriteLine("7. feladat: ");

// 8. feladat
