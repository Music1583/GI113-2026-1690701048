/*
* Student ID : 1690701048
* Name       : Sorawan Songkhunnatam
* Section    : 129A
* No.        : 36
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int live = 0;
            if (live == 0)
            {
                Console.WriteLine("Game over");
            }
            Console.WriteLine("continue runing");

            //2
            int coins = 80;
            int price = 10;
            if (coins >= price)
            {
                Console.WriteLine("Purchased");
            }
            else
            {
                Console.WriteLine("Not enough coins.");
            }

            //3
            int score = 75;
            if (score >= 90)
            {
                Console.WriteLine("Rank S");
            }
            else if (score >= 60) 
            {
                Console.WriteLine("Rank A");
            }
            else
            {
                Console.WriteLine("Rank B");
            }

            //4
            bool hasKey = true;
            Console.Write("your level (1-99) : ");
            bool isok = int.TryParse(Console.ReadLine(), out int level);

            if (!isok || level <= 1 || level > 99)
            {
                Console.WriteLine("Invalid level , plase try again");
            }
            else if (level >= 10 && hasKey)
            {
                Console.WriteLine("Boos floor unlock");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door open ");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }

        }
    }
}
