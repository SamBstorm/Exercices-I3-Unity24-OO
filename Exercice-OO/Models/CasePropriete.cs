using Exercice_OO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public class CasePropriete : Case, IProprietaire
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

        private void Acheter(Joueur acheteur)
        {
            //if (acheteur.Solde < this.Prix) return;     //Gestion d'exception
            try
            {
                acheteur.Payer(this.Prix);
                this.Proprietaire = acheteur;
                acheteur.AjouterPropriete(this);
            }
            catch (NotEnoughMoneyException nomEx)
            {
                throw new NotEnoughMoneyException(nomEx.Payeur, nomEx.Montant, this);
            }
        }

        private void Sejourner(Joueur visiteur)
        {
            int loyer = Prix / 4;
            visiteur.Payer(loyer);
            Proprietaire.EtrePayer(loyer);
        }

        public override void Activer(Joueur visiteur)
        {
            if(Proprietaire is null)
            {
                Acheter(visiteur);
            }
            else if( Proprietaire != visiteur && !EstHypotequee)
            {
                Sejourner(visiteur);
            }
        }

        public void Hypothequer()
        {
            if (EstHypotequee) return;      //Gestion d'exception
            EstHypotequee = true;
            Proprietaire.EtrePayer(Prix / 2);
        }

        public void Deshypothequer()
        {
            if(!EstHypotequee) return;
            Proprietaire.Payer(Prix * 3 / 5);
            EstHypotequee = false;
        }
    }
}
