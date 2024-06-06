using Exercice_OO.Enums;
using Exercice_OO.Models;

namespace Exercice_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Test De
            Console.WriteLine("Attention, je lance deux dés !");
            foreach (int resultLance in De.Lancer(2)) {
                Console.WriteLine($"Un dé me retourne : {resultLance}");
            }
            */

            Joueur j1 = new Joueur();
            j1.Nom = "Sam";
            j1.Pion = Pions.Dino;

            Console.WriteLine($"Bonjour Joueur 1 ({j1.Nom}) : Votre {j1.Pion} est à la case {j1.Position}.");

            while (j1.Avancer())
            {
                Console.WriteLine($"Vous arrivez en case {j1.Position} et vous avez fais un double! Rejouez!");
            }
            Console.WriteLine($"Vous avez atterri sur la case {j1.Position}, laissez votre tour au suivant.");
        }
    }
}
