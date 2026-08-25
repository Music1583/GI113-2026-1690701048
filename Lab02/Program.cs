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
            string role = "";
            char character_Name = 'm';
            int ammo = 0;
            float attackPower_2 = 42.5f;
            double criteMultiplier_2 = 1.75;
            // ตัวละครตัวที่ 2
            /*string character_Name_2 = "D";        
            char rank = 's';                    
            int ammo_2 = 20;                      
            float attackPower_2 = 42.5f;          
            double criteMultiplier = 1.75;      
            // ตัวละครตัวที่ 3
            string character_Name3 = "J";        
            char rank = 's';                    
            int ammo_3 = 25;                     
            float attackPower_3 = 42.5f;          
            double criteMultiplier = 1.75;      
            // ตัวละครตัวที่ 4
            string character_Name4 = "K";        
            char rank = 's';                   
            int ammo_4 = 35;                      
            float attackPower_4 = 42.5f;          
            double criteMultiplier = 1.75;      
            bool isBoss = true;*/
            Console.WriteLine("---Game ยิงปืน 4 คน---");
            Console.WriteLine(" ตัวละครที่ 1 ");
        }
    }
}
