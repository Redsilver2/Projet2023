using System;
using System.Diagnostics;

public class Metric
{
	public Metric()
	{

		string measure1, measure2;

        while (true)
		{
            Console.WriteLine("Entrer une mesure que vous utilisez (mm, cm, dm, m ou km)."); 
			measure1 = Console.ReadLine();

			switch (measure1.ToLower())
			{
				case "mm":
					break;

                case "cm":
                    break;

                case "dm":
                    break;

                case "m":
                    break;

                case "km":
                    break;


                default:

					break;


            }

        }
    }
}
