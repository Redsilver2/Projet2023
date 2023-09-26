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
                Console.WriteLine("\nQuel option voulez-vous choisir (Quiz, Weather, Money or Quit) ?");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "quiz":
                        break;

                    case "weather":
                        break;

                    case "money":
                        new Monnaie();
                        break;
                 
                    case "quit":
                        Console.WriteLine("\nPassez une belle journée.");
                        return;

                    default:
                        Console.WriteLine("\nCette commande n'existe pas.");
                        break;
                }
            }
        }
    }
}
