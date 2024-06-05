using Exercice_OO.Models;

namespace Exercice_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attention, je lance deux dés !");
            foreach (int resultLance in De.Lancer(2)) {
                Console.WriteLine($"Un dé me retourne : {resultLance}");
            }
        }
    }
}
