/*
 * Student ID : 1690701048
 * Name       : ศรวัณ ส่งคุณธรรม
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A
            string bossName = "Kirin";        // string เป็นข้อความใส่ใน ".."
            char rank = 's';                    // char เป็นตัวอักษร 1 ตัว ใส่ใน '..'
            int level = 7;                      // int เป็นจำนวนเต็ม 
            int maxHp = 240;
            int currenthp = 175;
            float attackPower = 42.5f;          // float เป็นเลขทศนิยมต้องเติม f ต่อท้าย
            double criteMultiplier = 1.75;      // double เป็นเลขทศนิยมที่ไม่ต้องเติม f เก็บได้หลายหลัก
            bool isBoss = true;                 // bool เป็นเงื่อนไขใส่ True/false มีค่าเป็น 0/1
            int hpPercent = 0;
            Console.WriteLine("===== BOSS STATUS: INITIAL ====="); //hell
            Console.WriteLine($"Name : {bossName}\n" +
                $"Rank : {rank}\n" +
                $"Level : {level}\n" +
                $"Hp : {currenthp} / {maxHp}\n" +
                $"Attack Power: {attackPower}\n" +
                $"Crite Multiplier : {criteMultiplier}\n" +
                $"Is Boss : {isBoss}");
            Console.WriteLine();
            hpPercent = currenthp * 100 / maxHp;
            Console.WriteLine($"HP Percent : {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin take 60 damage! ");
            currenthp = currenthp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {currenthp} / {maxHp}");
            hpPercent = currenthp * 100 / maxHp;
            Console.WriteLine($"HP Percent : {hpPercent}%");
            // Part B
            // ตัวละครตัวที่ 1
            Console.WriteLine("=====Character in Game shooting=====");
            Console.WriteLine("--Character 1--");
            string role = "hunter";
            char character_Name = 'M';
            int ammo = 35;
            int HP = 10;
            float attackPower_2 = 10.5f;
            double attackSpeed = 1;
            bool play_able = true;
            Console.WriteLine($"Name : {character_Name}\n" +
                $"role : {role}\n" +
                $"Hp : {HP}\n" +
                $"Ammo : {ammo}\n" +
                $"Attack Power : {attackPower_2}\n" +
                $"Attack Speed : {attackSpeed}\n" +
                $"Play able : {play_able}");
            // ตัวละครตัวที่ 2
            Console.WriteLine("--Character 2--");
            role = "bodyguard";
            character_Name = 'D';
            ammo = 30;
            HP = 20;
            attackPower_2 = 12.5f;
            attackSpeed = 0.7;
            play_able = true;
            Console.WriteLine($"Name : {character_Name}\n" +
              $"role : {role}\n" +
              $"Hp : {HP}\n" +
              $"Ammo : {ammo}\n" +
              $"Attack Power : {attackPower_2}\n" +
              $"Attack Speed : {attackSpeed}\n" +
              $"Play able : {play_able}");
            // ตัวละครตัวที่ 3
            Console.WriteLine("--Character 3--");
            role = "Human";
            character_Name = 'J';
            ammo = 15;
            HP = 10;
            attackPower_2 = 5.5f;
            attackSpeed = 0.5;
            play_able = true;
            Console.WriteLine($"Name : {character_Name}\n" +
              $"role : {role}\n" +
              $"Hp : {HP}\n" +
              $"Ammo : {ammo}\n" +
              $"Attack Power : {attackPower_2}\n" +
              $"Attack Speed : {attackSpeed}\n" +
              $"Play able : {play_able}");
            // ตัวละครตัวที่ 4
            Console.WriteLine("--Character 4--");
            role = "Vampire";
            character_Name = 'E';
            HP = 15;
            ammo = 35;
            attackPower_2 = 15f;
            attackSpeed = 1.2;
            play_able = false;
            Console.WriteLine($"Name : {character_Name}\n" +
              $"role : {role}\n" +
              $"Hp : {HP}\n" +
              $"Ammo : {ammo}\n" +
              $"Attack Power : {attackPower_2}\n" +
              $"Attack Speed : {attackSpeed}\n" +
              $"Play able : {play_able}");
        }
    }
}
