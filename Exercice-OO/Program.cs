using Exercice_OO.Enums;
using Exercice_OO.Models;

namespace Exercice_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Test class De
            Console.WriteLine("Attention, je lance deux dés !");
            foreach (int resultLance in De.Lancer(2)) {
                Console.WriteLine($"Un dé me retourne : {resultLance}");
            }
            */

            /* Test class Joueur
            Joueur j1 = new Joueur();
            j1.Nom = "Sam";
            j1.Pion = Pions.Dino;

            Console.WriteLine($"Bonjour Joueur 1 ({j1.Nom}) : Votre {j1.Pion} est à la case {j1.Position}.");

            while (j1.Avancer())
            {
                Console.WriteLine($"Vous arrivez en case {j1.Position} et vous avez fais un double! Rejouez!");
            }
            Console.WriteLine($"Vous avez atterri sur la case {j1.Position}, laissez votre tour au suivant.");
            */

            CasePropriete premiereCase = new CasePropriete(
                "Avenue des cerisiers", 
                Couleurs.Marron, 
                10);

            Joueur j1 = new Joueur("Sam", Pions.Dino);

            Console.WriteLine($"Le joueur {j1.Nom}, arrive sur la case {premiereCase.Nom}.");
            Console.WriteLine($"Il a actuellement {j1.Proprietes.Length} propriété(s)");
            Console.WriteLine($"Il a actuellement {j1.Solde} Monopoly");

            premiereCase.Acheter(j1);
            Console.WriteLine($"Il a actuellement {j1.Proprietes.Length} propriété(s)");
            Console.WriteLine($"Il a actuellement {j1.Solde} Monopoly");


        }
    }
}
