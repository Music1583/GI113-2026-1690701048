/*
* Student ID : 1690701048
* Name       : Sorawan Songkhunnatam
* Section    : 129A
* No.        : 36
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //game don't strave together
            
            const string type = "Neutral Animal";
            var gameName = "Don't strave together";
            var tier = 's';
            string newName = "Wooby";
            string oriName= "Beefalo";
            int hp = 1000;
            float normalspeed = 7.0f;
            double attackPower = 34.9;
            bool cantame = true;
            bool isfriendly = true;
            Console.WriteLine($"_______{gameName}_______");
            Console.WriteLine("_______   STATUS BEEFALO    _______"); // Beefalo คือมอนในเกมที่สามารถขี่ได้
            Console.WriteLine($"Original Name    : {oriName} ");
            Console.WriteLine($"New Name (Custom): {newName}");
            Console.WriteLine($"Type             : {type}");
            Console.WriteLine($"HP               : {hp} ");
            Console.WriteLine($"Speed            : {normalspeed}");
            Console.WriteLine($"Attack Power     : {attackPower}");
            Console.WriteLine($"Can Taming       : {cantame}");
            Console.WriteLine($"Is Friendly      : {isfriendly}");
            Console.WriteLine($"Tier             : {tier}");

            Console.WriteLine("_______  CONVERT VARIABLE   _______");
            double hpasdouble = hp;
            Console.WriteLine($"Hp as double (implicit): {hpasdouble}");
            int attackTruncated = (int)attackPower;               // explicit cast
            int attackRounded = Convert.ToInt32(attackPower);      // Convert
            Console.WriteLine($"Attack Power cast (truncates)  : {attackTruncated}");
            Console.WriteLine($"Attack Power Convert (rounds)  : {attackRounded}");
        }
    }
}
