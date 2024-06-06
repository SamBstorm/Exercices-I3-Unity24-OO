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
        public string nom;
        public Pions pion;
        public int position;

        public bool Avancer()
        {
            int[] resultatLance = De.Lancer(2);
            position += resultatLance[0] + resultatLance[1];
            return resultatLance[0] == resultatLance[1];
        }
    }
}
