using System;

public class Monnaie
{
	public Monnaie()
	{
        string? sMoneytypes;
        string? sAn;
        string? sAn2;
        string? sAn3;
        string? sLin;

        double dFinal;

        double dArgent;
        double dUS;


        Console.WriteLine("Quel type d'argent avez vous? CAD, US, EUR ");
        sAn = Console.ReadLine();





        if (sAn == "CAD" || sAn == "cad")
        {
            Console.WriteLine("En quel monnaie voulez-vous convertir?  US, EUR ");
            sAn2 = Console.ReadLine();

            if (sAn2 == "US" || sAn2 == "us")
            {
                Console.WriteLine("Combien avez vous en CAD");
                sAn3 = Console.ReadLine();
                dArgent = Convert.ToDouble(sAn3);

                dFinal = dArgent * 0.74;

                Console.WriteLine(sAn3 + "CAD = " + dFinal + "US");
            }
            else
            {
                Console.WriteLine("Combien avez vous en CAD");
                sAn3 = Console.ReadLine();
                dArgent = Convert.ToDouble(sAn3);

                dFinal = dArgent * 0.70;

                Console.WriteLine(sAn3 + "CAD = " + dFinal + "EUR");
            }
        }
        else if (sAn == "US" || sAn == "us")
        {

            Console.WriteLine("En quel monnaie voulez-vous convertir?  CAD, EUR ");
            sAn2 = Console.ReadLine();

            if (sAn2 == "CAD" || sAn2 == "cad")
            {

                Console.WriteLine("Combien avez vous en US");
                sAn3 = Console.ReadLine();
                dArgent = Convert.ToDouble(sAn3);

                dFinal = dArgent * 1.35;
                Console.WriteLine(sAn3 + "US = " + dFinal + "CAD");
            }
            else
            {
                Console.WriteLine("Combien avez vous en US");
                sAn3 = Console.ReadLine();
                dArgent = Convert.ToDouble(sAn3);

                dFinal = dArgent * 0.94;
                Console.WriteLine(sAn3 + "US = " + dFinal + "EUR");
            }



        }
        else if (sAn == "EUR" || sAn == "eur")
        {

            Console.WriteLine("En quel monnaie voulez-vous convertir?  CAD, US ");
            sAn2 = Console.ReadLine();

            if (sAn2 == "CAD" || sAn2 == "cad")
            {

                Console.WriteLine("Combien avez vous en EUR");
                sAn3 = Console.ReadLine();
                dArgent = Convert.ToDouble(sAn3);

                dFinal = dArgent * 1.44;
                Console.WriteLine(sAn3 + "EUR = " + dFinal + "CAD");

            }
            else
            {
                Console.WriteLine("Combien avez vous en EUR");
                sAn3 = Console.ReadLine();
                dArgent = Convert.ToDouble(sAn3);

                dFinal = dArgent * 1.07;
                Console.WriteLine(sAn3 + "EUR = " + dFinal + "US");
            }
}
