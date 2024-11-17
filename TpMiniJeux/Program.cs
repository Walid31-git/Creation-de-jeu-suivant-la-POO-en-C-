namespace TpMiniJeux
{
    namespace TpMiniJeux
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Joueur player = new Joueur("Stephane");
                player.JeterDe();
                Random random = new Random();

                while (player.PointDeVie > 0 )
                {
                    int typeMonstre = random.Next(1, 3);
                    if (typeMonstre == 1)
                    {
                       
                        MonstreNiveau1 monstre1 = new MonstreNiveau1();
                        monstre1.Attaquer(player);
                    }
                    else
                    {
                        MonstreNiveau2 monstre2 = new MonstreNiveau2();
                        monstre2.Attaquer(player);
                    }

                }
                Console.WriteLine($"Le Joueur {player.NomJoueur} est mort, RIP");

                Console.WriteLine($"Bravo, vous avez tué {(player.compteurMonstre1)/2} monstres de niveau 1 et {player.compteurMonstre2} monstres de niveau 2");
                int scoretotale =( player.compteurMonstre1/ 2) + (player.compteurMonstre2*2);
                Console.WriteLine($"Vous avez gagner {scoretotale} points");

                Console.WriteLine("Merci d'avoir joué !");
            }
        }
    }
}