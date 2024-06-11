﻿using Exercice_OO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public class CasePropriete : Case
    {
        public Couleurs Couleur { get; private set; }
        public int Prix { get; private set; }
        public bool EstHypotequee { get; private set; }
        public Joueur Proprietaire { get; private set; }

        public CasePropriete(string nom, Couleurs couleur, int prix) : base(nom)
        {
            this.Couleur = couleur;
            this.Prix = prix;
            //Les lignes suivantes sont non-obligatoire, car c'est l'attribution de valeur par défaut.
            //ATTENTION : si la valeur doit être différente de la valeur par défaut, la ligne devient obligatoire
            //EstHypotequee = false;
            //Proprietaire = null;
        }

        public void Acheter(Joueur acheteur)
        {
            if (acheteur.Solde < this.Prix) return;     //Gestion d'exception
            acheteur.Payer(this.Prix);
            this.Proprietaire = acheteur;
            acheteur.AjouterPropriete(this);
        }
    }
}
