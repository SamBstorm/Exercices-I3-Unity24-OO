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
            j1.nom = "Sam";
            j1.pion = Pions.Dino;

            Console.WriteLine($"Bonjour Joueur 1 ({j1.nom}) : Votre {j1.pion} est à la case {j1.position}.");

            while (j1.Avancer())
            {
                Console.WriteLine($"Vous arrivez en case {j1.position} et vous avez fais un double! Rejouez!");
            }
            Console.WriteLine($"Vous avez atterri sur la case {j1.position}, laissez votre tour au suivant.");
        }
    }
}
