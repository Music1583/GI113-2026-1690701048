/*
* Student ID : 1690701048
* Name       : Sorawan Songkhunnatam
* Section    : 129A
* No.        : 36
* Course     : GI113 Computer Programming (GI)
*/
using System.ComponentModel;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String name = "Music";
            const double smeltRate = 0.1700;
            const double SalvageRate = 0.2800;
            const double MaxBatch = 500.00;
            var inGot = 0.0;
            var ore = 0.0;
            Console.WriteLine("=======The Forge=======");
            Console.WriteLine("---Special ore today---");
            Console.WriteLine($"{name} ore Smelting 0.17 / Salvage 0.28");
            Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");
            Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvv");
            Console.Write("What you want to do : ");
            bool iskeychar = char.TryParse(Console.ReadLine(), out char key);
            
            if ( !iskeychar || (key != 's' && key != 'S' && key != 'b' && key != 'B'))
            {
                Console.WriteLine("error : plese text (s , S , B ,b)");
            }
         
            else if ( key == 'S' || key == 's' )
            {
                Console.Write("How much do you want to Smelt (1-500): ");
                bool isamountnum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isamountnum )
                {
                    Console.WriteLine("error : plese text (1-500)");
                }
                else if (isamountnum)
                {
                    if (amount <= 500 && amount > 0)
                    {
                        inGot = amount * smeltRate;
                        Console.WriteLine($"{amount:f2} {name} ore = {inGot:f2} {name} ingot");
                    }
                    else
                    {
                        Console.WriteLine("error : amount ");
                    }
                }
                else
                {
                    Console.WriteLine("error : plese text (1-500)  ");
                }

            }
            else if (key == 'B' || key == 'b')
            {
                Console.Write("How much do you want to Breakdown ( 1-500 ): ");
                bool isamountnum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isamountnum)
                {
                    Console.WriteLine("error : plese text (1-500) ");
                }
                else if (isamountnum)
                {
                    if ( amount <= 500 && amount > 0)
                    {
                        ore = amount / SalvageRate;
                        Console.WriteLine($"{amount:f2} {name} ingot = {ore:f2} {name} ore");
                    }
                    else
                    {
                        Console.WriteLine("error : amount ");
                    }
                }
                else
                {
                    Console.WriteLine("error : plese text (s , S , B ,b) ");
                }

            }
        }
    }
}
