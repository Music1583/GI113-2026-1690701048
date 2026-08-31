/*
* Student ID : 1690701048
* Name       : ศรวัณ ส่งคุณธรรม
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Maxlevel = 10;

            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //แสดงค่า output

            Console.WriteLine("===KIRIN SAVE CONVERTER===");
            Console.WriteLine($"Name : {bossName}\nRank : {rank}\nLevel : {level} / {Maxlevel}\nHp : {currentHp} / {maxHp}\nAttack Power: {attackPower}\nCrit Multiplier : {critMultiplier}\nIs Boss : {isBoss}");

            //ทำ implicit int  -> double 
            Console.WriteLine("\n---Implicit Conversion : HP as double ---");
            double currentHpDouble = currentHp;  //int -> double แปลงค่าแบบไม่ต้อง cast
            Console.WriteLine($"HP (double) : {currentHpDouble}");

            //ทำ implicit หลังการคำนวณเปร์เซ็ย ที่ผลลัพธ์มีทศนิยม
            Console.WriteLine("\n---Exact Hp percent  (no integer truncation )---");
            double HpPersent = currentHpDouble * 100 / maxHp; //int หาร int จากนั้นแปลงผลลัพธ์เป็น double เพื่อเก็บทศนิยม
            Console.WriteLine($"HP Persent (exact) : {HpPersent}%");

            //ทำ Explicit โดยการ Casting (float) attackpower -> int
            Console.WriteLine("\n---Explicit Cast : Attackpower -> Display int ---");
            int attackPowerint = (int)attackPower;
            Console.WriteLine($"AttackPower (int cast) :{attackPowerint}");

            // cast + convert 
            Console.WriteLine("\n--- cast vs convert  : Crit Multiplier ---");
            int critMultiplierCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"CritMultiplier (int cast) : {critMultiplierCast}");
            Console.WriteLine($"CritMultiplier (Convert rounded ) : {critConvert }");
        }
     }
}
