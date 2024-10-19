using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {

        Revue revue1 = new Revue("Nation Negres et culture", "Cheihk anta Diop", 2020, 123, 2022);
        Revue revue2 = new Revue("Goovi REhkmire", "histoires des cvilisations Negres", 2021, 456, 2022);
        Revue revue3 = new Revue("civilisation ou barbarie", "Cheihk Anta Diop", 2019, 789, 2022);

        List<Livre> livres = new List<Livre> { revue1, revue2, revue3 };
        Console.WriteLine("les livres; ");
        foreach (Livre l in livres)
        {
            l.AfficherDetails();
        }
    }
}