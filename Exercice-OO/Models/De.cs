using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_OO.Models
{
    public static class De
    {
        private static int _valeurMin = 1;
        private static int _valeurMax = 6;
        private static Random _rng = new Random();

        public static int ValeurMin
        {
            get { return _valeurMin; }
            set {
                if (value <= 0) return; //Gestion d'exception
                if (value >= _valeurMax) _valeurMax = value + 1;
                _valeurMin = value;
            }
        }
        public static int ValeurMax
        {
            get { return _valeurMax; }
            set
            {
                if (value <= 1) return; //Gestion d'exception
                if (value <= _valeurMin) _valeurMin = value - 1;
                _valeurMax= value;
            }
        }
        public static int[] Lancer(int nbDes)
        {
            int[] result = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                int x = _rng.Next(_valeurMin, _valeurMax + 1);
                result[i] = x;
            }
            return result;
        }
    }
}
