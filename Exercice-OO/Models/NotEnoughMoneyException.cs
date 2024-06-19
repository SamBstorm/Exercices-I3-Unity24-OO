using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public class NotEnoughMoneyException : Exception
    {
        public Joueur Payeur { get; private set; }
        public int Montant { get; private set; }
        public CasePropriete Bien { get; private set; }

        public NotEnoughMoneyException(Joueur payeur, int montant) :
            base($"{payeur.Nom} n'a pas su payer la somme de {montant}.")
        {
            Payeur = payeur;
            Montant = montant;
        }

        public NotEnoughMoneyException(Joueur payeur, int montant, CasePropriete bien) :
            base($"{payeur.Nom} n'a pas su payer la somme de {montant} pour acquérir le bien {bien.Nom}.")
        {
            Payeur = payeur;
            Montant = montant;
            Bien = bien;
        }
    }
}
