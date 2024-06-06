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
        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }
        public int Solde { get; private set; }
        public string Nom { get; set; }
        public Pions Pion { get; set; }

        public bool Avancer()
        {
            int[] resultatLance = De.Lancer(2);
            Position += resultatLance[0] + resultatLance[1];
            return resultatLance[0] == resultatLance[1];
        }
    }
}
