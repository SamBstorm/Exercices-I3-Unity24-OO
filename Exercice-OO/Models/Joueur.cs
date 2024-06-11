using Exercice_OO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public class Joueur
    {
        private int _position;
        private List<CasePropriete> _proprietes;
        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }
        public int Solde { get; private set; }
        public string Nom { get; set; }
        public Pions Pion { get; set; }
        public CasePropriete[] Proprietes
        {
            get { return _proprietes.ToArray(); }
        }

        public Joueur(string nom, Pions pion)
        {
            this.Nom = nom;
            this.Pion = pion;
            this.Solde = 1500;
            this._proprietes = new List<CasePropriete>();
            //this.Position = 0;
        }

        public bool Avancer()
        {
            int[] resultatLance = De.Lancer(2);
            Position += resultatLance[0] + resultatLance[1];
            return resultatLance[0] == resultatLance[1];
        }

        public void EtrePayer(int montant)
        {   
            if(montant <= 0) return;    //Gestion d'exception
            Solde += montant;
        }

        public void Payer(int montant)
        {
            if (montant <= 0) return;    //Gestion d'exception
            if (montant > Solde) return; //Gestion d'exception
            Solde -= montant;
        }

        public void AjouterPropriete(CasePropriete propriete) 
        {
            if(this == propriete.Proprietaire)
            {
                _proprietes.Add(propriete);
            }
        }

        public static Joueur operator +(Joueur left, int right)
        {
            left.EtrePayer(right);
            return left;
        }

        public static CasePropriete[] operator + (Joueur left, CasePropriete right)
        {
            right.Acheter(left);
            return left.Proprietes;
        }
    }
}
