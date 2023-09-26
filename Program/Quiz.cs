using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Quiz
    {
        public Quiz()
        {


            {

                string sRep;


                Console.WriteLine("Connaissez-vous vos capitale?");

                Console.WriteLine("Question 1 : Quel est la capitale de la France?");
                sRep = Console.ReadLine();
                if (sRep == "Paris" || sRep == "paris")
                {
                    Console.WriteLine("Bonne Réponse!");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse...");
                }



                Console.WriteLine("Question 2 : Quel est la capitale de l'Espagne?");
                sRep = Console.ReadLine();
                if (sRep == "Madrid" || sRep == "madird")
                {
                    Console.WriteLine("Bonne Réponse!");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse...");
                }



                Console.WriteLine("Question 3 : Quel est la capitale de la Grèce?");
                sRep = Console.ReadLine();
                if (sRep == "Athènes" || sRep == "athènes" || sRep == "Athenes" || sRep == "athene")
                {
                    Console.WriteLine("Bonne Réponse!");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse...");
                }




                Console.WriteLine("Question 4 : Quel est la capitale des Pays-Bas?");
                sRep = Console.ReadLine();
                if (sRep == "Amsterdam" || sRep == "amsterdam")
                {
                    Console.WriteLine("Bonne Réponse!");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse...");
                }


                Console.WriteLine("Question 5 : Quel est la capitale du Royaume-Uni?");
                sRep = Console.ReadLine();
                if (sRep == "Londres" || sRep == "londre")
                {
                    Console.WriteLine("Bonne Réponse!");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse...");
                }


                Console.WriteLine("Question 6 : Quel est la capitale de l'Allemange?");
                sRep = Console.ReadLine();
                if (sRep == "Berlin" || sRep == "berlin")
                {
                    Console.WriteLine("Bonne Réponse!");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse...");
                }
            }
        }
    }
}
