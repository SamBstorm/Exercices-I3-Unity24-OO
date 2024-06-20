using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    /// <summary>
    /// Le delegate CaseDelegate représente l'action que le joueur visiteur doit effectuer lorsqu'il atterri sur cette case.
    /// </summary>
    /// <param name="visiteur">Joueur ayant atterri sur la case</param>
    public delegate void CaseDelegate(Joueur visiteur);
    /// <summary>
    /// La class CaseAction représente une case du plateau avec une action spécifique lorsque le joueur l'atteind.
    /// Un delegate CaseDelegate permet de pouvoir stocker le bloc d'instruction inconnu de cette case.
    /// Avec ce genre de case, il sera possible de définir une case "Impôts" qui demande au joueur de payer un impôts défini par le delegate.
    /// </summary>
    public class CaseAction : Case
    {
        //Champ stockant l'action de cette case
        private CaseDelegate _action;
        //Le constructeur permet l'initialisation de la case avec son nom et son action
        public CaseAction(string nom, CaseDelegate action) : base(nom)
        {
            _action = action;
        }
        //La méthode Activer est obligatoirement rédéfinie par l'abstraction, ici elle aura le rôle d'activer l'action spécifique de la case
        public override void Activer(Joueur visiteur)
        {
            _action?.Invoke(visiteur);
        }
    }
}
