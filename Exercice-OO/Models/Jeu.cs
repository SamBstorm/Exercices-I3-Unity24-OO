using Exercice_OO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public class Jeu
    {
        private List<Joueur> _joueurs;
        private List<Case> _plateau;

        public Joueur[] Joueurs { get {  return _joueurs.ToArray(); } }
        public Case[] Plateau { get { return _plateau.ToArray(); } }

        public Case this[int index]
        {
            get {
                //if (index >= _plateau.Count) return null;
                //return _plateau[index]; 

                //Permet de faire le tour du plateau
                return _plateau[index % _plateau.Count];
            }
        }

        public Joueur this[Pions pion]
        {
            get {
                foreach (Joueur j in _joueurs)
                {
                    if(j.Pion == pion) return j;
                }
                return null;
            }
        }

        public Jeu(Case[] plateau)
        {
            _plateau = new List<Case>();
            _plateau.AddRange(plateau);
            _joueurs = new List<Joueur>();
        }

        public void AjouterJoueur(string nom, Pions pion)
        {
            if (this[pion] is null) _joueurs.Add(new Joueur(nom, pion));
        }
    }
}
