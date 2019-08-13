using System;

namespace Ohm_s_lov
{
    class Program
    {
        static void Main(string[] args)
        {
            // modstang * strøm = spænd --- effekt = strøm * spænding
            string modstand, strøm;
            double spænding, effekt; 
            Console.Write("Du er ved at udregne spænding i Ohm's lov. ");


            Console.WriteLine("Hvad er modstanden?");
            modstand = Console.ReadLine();

            double modstand2 = float.Parse(modstand);

            Console.WriteLine("Hvad er strømstyrken?");
            strøm = Console.ReadLine();

            double strøm2 = float.Parse(strøm);



            // udregning
            spænding = modstand2 * strøm2;
            effekt = strøm2 * spænding;

            Console.WriteLine("Spændingen er {0}", spænding);
            Console.WriteLine("Effekten er {0}", effekt);

            





        }
    }
}
