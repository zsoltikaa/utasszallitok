namespace utasszallitokCLI
{
    public class Repulogep
    {

        public string Tipus { get; set; }
        public int Ev { get; set; }
        public string Utas { get; set; }
        public string Szemelyzet { get; set; }
        public int Utazosebesseg { get; set; }
        public int Felszallotomeg { get; set; }
        public double Fesztav { get; set; }

        public Repulogep(string line)
        {
            var ls = line.Split(';');

            Tipus = ls[0];
            Ev = int.Parse(ls[1]);
            Utas = ls[2];
            Szemelyzet = ls[3];
            Utazosebesseg = int.Parse(ls[4]);
            Felszallotomeg = int.Parse(ls[5]);
            Fesztav = double.Parse(ls[6]);
        }

    }
}
