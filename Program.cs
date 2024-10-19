using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {

        Revue revue1 = new Revue("Nation Negres et culture", "Cheihk anta Diop", 2021, 123, 1989);
        Revue revue2 = new Revue("Goovi REhkmire", "histoires des cvilisations Negres", 2021, 456, 2022);
        Revue revue3 = new Revue("civilisation ou barbarie", "Cheihk Anta Diop", 2019, 789, 1996);

        Roman roman1 = new Roman("L'enfant Noir", "Camara Laye", 197, "Aventure");
        Roman roman2 = new Roman("Saison de la migration vers le Nord", "Tayeb Sahil", 271, "romanesque");
        Roman roman3 = new Roman("Etonner les Dieux", "Ben Okri", 335, "Drame");



        List<Livre> livres = new List<Livre> { revue1, revue2, revue3 , roman1, roman2, roman3 };

        Console.WriteLine("les livres; ");
        foreach (Livre l in livres)
        {
            l.AfficherDetails();
        }
    }
}