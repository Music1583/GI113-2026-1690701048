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
            ////1
            //int live = 0;
            //if (live == 0)
            //{
            //    Console.WriteLine("Game over");
            //}
            //Console.WriteLine("continue runing");

            ////2
            //int coins = 80;
            //int price = 10;
            //if (coins >= price)
            //{
            //    Console.WriteLine("Purchased");
            //}
            //else
            //{
            //    Console.WriteLine("Not enough coins.");
            //}

            ////3
            //int score = 75;
            //if (score >= 90)
            //{
            //    Console.WriteLine("Rank S");
            //}
            //else if (score >= 60) 
            //{
            //    Console.WriteLine("Rank A");
            //}
            //else
            //{
            //    Console.WriteLine("Rank B");
            //}

            ////4
            //bool hasKey = true;
            //Console.Write("your level (1-99) : ");
            //bool isok = int.TryParse(Console.ReadLine(), out int level);

            //if (!isok || level <= 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level , plase try again");
            //}
            //else if (level >= 10 && hasKey)
            //{
            //    Console.WriteLine("Boos floor unlock");
            //}
            //else if (level >= 5)
            //{
            //    Console.WriteLine("The door open ");
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");
            //}

            Console.WriteLine("+++++++Moodeng+++++++");
            Console.WriteLine("+++++++INFO+++++++");
            Console.Write("what is your name : ");
            string name = Console.ReadLine();
            Console.Write("choose you hp ( number ): ");
            bool isHpTrue = int.TryParse(Console.ReadLine(), out int hp);
            if (!isHpTrue) // โค้ดมีปัญหาค้าบอยากใช้ loop
            {
                Console.Write("choose you hp again plase : ");
                isHpTrue = int.TryParse(Console.ReadLine(), out  hp);
            }

            Console.Write("Choose your power (1-99) : ");
            bool isPowerTrue = int.TryParse(Console.ReadLine(), out int power);
            if (!isPowerTrue || power > 99 || power < 1 ) // โค้ดมีปัญหาค้าบอยากใช้ loop
            {
                Console.Write("choose you power again plase : ");
                isPowerTrue = int.TryParse(Console.ReadLine(), out power);
            }
            string enemy = "Moodeng";
            int hpMooDeng = hp + 1;
            int powerMoodeng = power + 1;

            Console.WriteLine(".......\n.......\n.......\n.......\n.......\n.......");
            Console.WriteLine($"Hi {name} ");
            Console.WriteLine("YOU FIND A MOODENG...");
            Console.WriteLine("what you gonna do ?");
            Console.WriteLine(" A : Talk");
            Console.WriteLine(" B : Fight");
            Console.WriteLine(" C : Run");
            Console.Write("Choose what you gonna do (A - C) : ");
            bool isChar = Char.TryParse(Console.ReadLine(), out Char choice);
            if (!isChar || (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'A' && choice != 'B' && choice != 'C'))
            {
                Console.WriteLine("Invalid input , Plase choose A B C ...");
                Console.Write("choose you choice again plase : ");
                isChar = Char.TryParse(Console.ReadLine(), out choice);
                if (choice == 'A' || choice == 'a')
                {
                    Console.WriteLine($"{name} : Hi Moodeng");
                    Console.WriteLine($"{enemy} : ..... ");
                    Console.WriteLine("Noting respon... what you gonnna do ? ");
                    Console.WriteLine(" A : Talkagain");
                    Console.WriteLine(" B : Fight");
                    Console.WriteLine(" C : Run");
                    Console.Write("Choose what you gonna do (A - C) : ");
                    isChar = Char.TryParse(Console.ReadLine(), out Char choiceAfterTalk);
                    if (!isChar || (choiceAfterTalk != 'a' && choiceAfterTalk != 'b' && choiceAfterTalk != 'c' && choiceAfterTalk != 'A' && choiceAfterTalk != 'B' && choiceAfterTalk != 'C'))
                    {
                        Console.WriteLine("Invalid input , Plase choose A B C ...");
                        Console.Write("choose you choice again plase : ");
                        isChar = Char.TryParse(Console.ReadLine(), out choiceAfterTalk);
                    }
                }
                if (choice == 'B' || choice == 'b')
                {

                }
                if (choice == 'C' || choice == 'c')
                {

                }


            }
        }
    }
}
