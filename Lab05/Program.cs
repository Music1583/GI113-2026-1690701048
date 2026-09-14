/*
 * Student ID : 1690701048
 * Name       : Sorawan Songkhunnatam
 * Section    : 129A
 * No.        : 36
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== BATTLE Moodeng ======");
            Console.WriteLine("-- Human VS Moodeng -- Fight Calculator");

            // User input of human stats
            Console.Write("Human Health: ");
            bool isHumanHpNum = int.TryParse(Console.ReadLine(), out int hpHuman);
            Console.Write("Human Attack: ");
            bool isHumanAtkNum = int.TryParse(Console.ReadLine(), out int atkHuman);
            Console.Write("Human Defence: ");
            bool isHumanDefNum = int.TryParse(Console.ReadLine(), out int defHuman);

            // User input of Moodeng stats
            Console.Write("Moodeng Health: ");
            bool isMoodengHpNum = int.TryParse(Console.ReadLine(), out int hpMoodeng);
            Console.Write("Moodeng Attack: ");
            bool isMoodengAtkNum = int.TryParse(Console.ReadLine(), out int atkMoodeng);
            Console.Write("Moodeng Defence: ");
            bool isMoodengDefNum = int.TryParse(Console.ReadLine(), out int defMoodeng);

            // check if player input is valid
            bool allStastHumanValid = isHumanHpNum && isHumanAtkNum && isHumanDefNum;
            bool allStastMoodengValid = isMoodengHpNum && isMoodengAtkNum && isMoodengDefNum;
            Console.WriteLine($"Stats Validation Human : {allStastHumanValid} , Moodeng : {allStastMoodengValid}");
            Console.WriteLine($"[Human]  HP : {hpHuman} ATK : {atkHuman} DEF : {defHuman}");
            Console.WriteLine($"[Moodeng]  HP : {hpMoodeng} ATK : {atkMoodeng} DEF : {defMoodeng}");

            //Before fright Human drinking potion (Compound Assignment)
            int potionHeal = 8;
            // 1 Normail 1 = 1 + 2
            //hpHuman = hpHuman + potionHeal;
            // 2 !Normal 1 = 1 + 2 เหมือนกันแต่ไม่เหมือนกัน
            hpHuman += potionHeal;
            Console.WriteLine($"\n Human Drinking a Potion , Healing {potionHeal} HP . health is now {hpHuman}. ");

            //คำนวน damage normal attack (Arithmetic + math)
            int normalDamage = Math.Max(0, atkHuman - defMoodeng);
            Console.WriteLine($"Normal Attack deal : {normalDamage} DMG ");

            //คำนวณ power attack (Predence ลำกับการคำนวณ คูณก่อนที่จะ ลบ )
            int powerDamage = Math.Max(0, atkHuman * 2 - defMoodeng);
            Console.WriteLine($"Power attack deal : {powerDamage} DMG ");

            // คำนวณ Moodeng attack
            int counterDamage = Math.Max(0, atkMoodeng - defHuman);
            Console.WriteLine($"Moodeng counter attack deal : {counterDamage} DMG");

            // คำนวณ cri chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // 1 - 100
            bool isCrit = roll <= 10; // 10%
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"\nCritical hit rool : {roll} (Critical : {isCrit})");
            Console.WriteLine($"Normal attack would deal Critical : critical {critDamage} DMG");
        }
    }
}
