/*
* Student ID : 1690701048
* Name       : Sorawan Songkhunnatam
* Section    : 129A
* No.        : 36
* Course     : GI113 Computer Programming (GI)
*/
using System.Runtime.ConstrainedExecution;

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

            Console.WriteLine("+++++++Moodeng simulator+++++++");
            Console.WriteLine("+++++++INFO+++++++");
            Console.Write("what is your name : ");
            string name = Console.ReadLine();
            Console.Write("choose you hp (1 - what ever you want): ");
            bool isHpTrue = int.TryParse(Console.ReadLine(), out int hp);
            if (!isHpTrue || hp < 1) 
            {
                Console.Write("choose you hp again plase : ");
                isHpTrue = int.TryParse(Console.ReadLine(), out hp);
            }

            Console.Write("Choose your power (1-99) : ");
            bool isPowerTrue = int.TryParse(Console.ReadLine(), out int power);
            if (!isPowerTrue || power > 99 || power < 1) 
            {
                Console.Write("choose you power again plase : ");
                isPowerTrue = int.TryParse(Console.ReadLine(), out power);
            }
            string enemy = "Moodeng";
            int hpMooDeng = (hp + power) * 2 ;
            int powerMoodeng = (hp + power) * 2;

            Console.WriteLine("vvvvv\nvvvvv\nvvvvv");
            Console.WriteLine($"Hi {name} ");
            Console.WriteLine("YOU FIND A MOODENG...");
            Console.WriteLine("what you gonna do ?");
            Console.WriteLine(" A : Talk");
            Console.WriteLine(" B : Fight");
            Console.WriteLine(" C : Run");
            Console.Write("Choose what you gonna do (A - C) : ");
            bool isChar = Char.TryParse(Console.ReadLine(), out Char choice);
            Console.WriteLine("vvvvv\nvvvvv\nvvvvv");
            if (!isChar || (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'A' && choice != 'B' && choice != 'C'))
            {
                Console.WriteLine("Invalid input , Plase choose A B C ...");
                Console.Write("choose you choice again plase : ");
                isChar = Char.TryParse(Console.ReadLine(), out choice);
            }
            else if (choice == 'A' || choice == 'a')
            {
                Console.WriteLine($"==Start talking==");
                Console.WriteLine($"{name} : Hi Moodeng");
                Console.WriteLine($"{enemy} : ..... ");
                Console.WriteLine("Noting respon... what you gonnna do ? ");
                Console.WriteLine(" A : Touch");
                Console.WriteLine(" B : Run");
                Console.Write("Choose what you gonna do (A - B) : ");
                isChar = Char.TryParse(Console.ReadLine(), out Char choiceAfterTalk);
                if (!isChar || (choiceAfterTalk != 'a' && choiceAfterTalk != 'b' && choiceAfterTalk != 'A' && choiceAfterTalk != 'B'))
                {
                    Console.WriteLine("Invalid input , Plase choose A B  ...");
                    Console.Write("choose you choice again plase : ");
                    isChar = Char.TryParse(Console.ReadLine(), out choiceAfterTalk);
                }
                if (choiceAfterTalk == 'A' || choiceAfterTalk == 'a')
                {
                    Console.WriteLine("vvvvv");
                    Console.WriteLine($"{name} : Touch Moodeng...");
                    Console.WriteLine($"{enemy} : !!!!! ");
                    Console.WriteLine($"{enemy} : attack you");
                    Console.WriteLine($"{enemy} : attack {powerMoodeng} damage");
                    Console.WriteLine($"{name} : take {powerMoodeng} damage");
                    hp =  hp - powerMoodeng;
                    Console.WriteLine($"{name} : have {hp} hp");
                    Console.WriteLine(" You die ");
                    Console.WriteLine("*** Tip ****");
                    Console.WriteLine("*** Dont touch if you dont wanna die  ****");
                    Console.WriteLine("*** Hippopotamuses have a powerful bite that can kill you  ****");
                }
                else if (choiceAfterTalk == 'B' || choiceAfterTalk == 'b')
                {
                    Console.Write($"\n-----Run as fast as {name} can -----\n");
                }
            }
            else if (choice == 'b' || choice == 'B')
            {
                Console.WriteLine($"{name} punch {enemy} ");
                Console.WriteLine($"{name} : attack {power} damage");
                Console.WriteLine($"{enemy} : take {power} damage");
                hpMooDeng = hpMooDeng - power ;
                Console.WriteLine($"{enemy} : have {hpMooDeng} hp");
                Console.WriteLine($"{enemy} bite {name} ");
                Console.WriteLine($"{enemy} : attack {powerMoodeng} damage");
                Console.WriteLine($"{name} : take {powerMoodeng} damage");
                hp = hp - powerMoodeng ;
                Console.WriteLine($"{name} : have {hp} hp");
                Console.WriteLine(" You die ");
                Console.WriteLine("*** Tip ****");
                Console.WriteLine("*** You just human can't fight moodeng just run ****");
            }
            else if (choice == 'c' || choice == 'C')
            {

                Console.Write($"\n-----Run as fast as {name} can -----\n");
            }

        }
    }
}
