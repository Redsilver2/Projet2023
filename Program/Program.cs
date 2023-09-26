using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Entrez votre nom:  ");
            string username = Console.ReadLine();

            Console.WriteLine($"\nBonjour {username}, ");
            
            while (true)
            {
                Console.WriteLine("\nQuel option voulez-vous choisir (Quiz, Weather, Metric or Quit) ?");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "quiz":
                        new Quiz();
                        break;

                    case "metric":
                        new Metric();
                        break;

                    case "money":
                        new Monnaie();
                        break;
                 
                    case "quit":
                        Console.WriteLine("\nPassez une belle journée.");
                        Console.WriteLine("Appuyez sur un clé pour continuer");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("\nCette commande n'existe pas.");
                        break;
                }
            }
        }
    }
}
