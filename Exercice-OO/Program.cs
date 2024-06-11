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

            /* Test class CasePropriete
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
            */

            Jeu monopoly = new Jeu(
                [
                    new CasePropriete("Entrée parc", Couleurs.Marron, 10),
                    new CasePropriete("Entrée métro", Couleurs.Marron, 12),
                    new CasePropriete("Cage ascenceur Bât. Gauche", Couleurs.BleuCiel, 14),
                    new CasePropriete("Cage ascenceur Bât. Droite", Couleurs.BleuCiel, 14),
                    new CasePropriete("Cage escalier de secours", Couleurs.BleuCiel, 18),
                    new CasePropriete("Toilette Femme", Couleurs.Violet, 22),
                    new CasePropriete("Toilette Homme", Couleurs.Violet, 22),
                    new CasePropriete("Toilette Mixte", Couleurs.Violet, 26),
                    new CasePropriete("Classe de WEB", Couleurs.Orange, 30),
                    new CasePropriete("Classe de WAD", Couleurs.Orange, 30),
                    new CasePropriete("Classe de GAMES", Couleurs.Orange, 32),
                    new CasePropriete("Réfectoire Bât. Gauche", Couleurs.Rouge, 36),
                    new CasePropriete("Réfectoire Bât. Droite", Couleurs.Rouge, 36),
                    new CasePropriete("Réfectaire administration", Couleurs.Rouge, 40),
                    new CasePropriete("Salle photocopieuses", Couleurs.Jaune, 44),
                    new CasePropriete("Salle des formateurs", Couleurs.Jaune, 44),
                    new CasePropriete("Salle de repos", Couleurs.Jaune, 48),
                    new CasePropriete("Passerelles Niv. 1 et 2", Couleurs.Vert, 52),
                    new CasePropriete("Passerelles Niv. 3 et 4", Couleurs.Vert, 52),
                    new CasePropriete("Patio", Couleurs.Vert, 56),
                    new CasePropriete("Bureau Sonia", Couleurs.Bleu, 60),
                    new CasePropriete("Bureau Nicole", Couleurs.Bleu, 64)
                ]);
            Console.WriteLine("Bienvenu dans Monopoly Interface 3 Le jeu Deluxe Edition SP Lite Turbo");
            int nbJoueur;
            do
            {
                Console.WriteLine("Combien de joueurs êtes-vous ?");
            } while (!int.TryParse(Console.ReadLine(), out nbJoueur) || nbJoueur < 2 || nbJoueur > 6);

            for (int i = 0; i < nbJoueur; i++)
            {
                Console.WriteLine($"Joueur {i+1} : Quel est votre nom ?");
                string name = Console.ReadLine();
                Console.WriteLine($"{name} : Veuillez choisir un Pion :");
                foreach (string pionName in Enum.GetNames<Pions>())
                {
                    Console.WriteLine($"\t- {pionName}");
                }
                string pion = Console.ReadLine();
                monopoly.AjouterJoueur(name, Enum.Parse<Pions>(pion));
            }

            foreach (Joueur j in monopoly.Joueurs)
            {
                j.Avancer();
                CasePropriete caseActuelle = monopoly[j.Position];
                Console.WriteLine($"{j.Nom} avance avec son/sa {j.Pion} sur la case {caseActuelle.Nom}");
                CasePropriete[] casesDeJ = j + caseActuelle;
                Console.WriteLine($"{j.Nom} a actuellement {casesDeJ.Length} propriété(s)");
                Console.WriteLine($"{j.Nom} a actuellement {j.Solde} Monopoly");
            }
        }
    }
}
