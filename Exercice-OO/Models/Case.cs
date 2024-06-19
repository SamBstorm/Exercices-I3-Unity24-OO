﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public abstract class Case : IVisiteur
    {
        private List<Joueur> _visiteurs;
        public string Nom { get; }
        public Joueur[] Visiteurs { get { return _visiteurs.ToArray(); } }
        public Case(string nom)
        {
            Nom = nom;
            _visiteurs = new List<Joueur>();
        }
        public void AjouterVisiteur(Joueur visiteur)
        {
            _visiteurs.Add(visiteur);
        }
        public void RetirerVisiteur(Joueur visiteur)
        {
            _visiteurs.Remove(visiteur);
        }

        public abstract void Activer(Joueur visiteur);
    }
}
