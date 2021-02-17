using System;

namespace CSHARP_Boucles_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            while (count < 11)
            {
                Console.WriteLine($"Ceci n'est que le message de test numéro {count}. Veuillez ne pas y prêter attention");
                count++;
            }
        }
    }
}