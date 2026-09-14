/*
* Student ID : 1690700149
* Name       : Natitorn Saisopon
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

using System.Runtime.ConstrainedExecution;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==> KRNX <== ");
            Console.WriteLine("[Ken vs. Zen] -- Fight Calculator");

            // ken input stats
            Console.Write("ken Health : ");
            bool iskenHp = int.TryParse(Console.ReadLine(), out int kenHp);

            Console.Write("ken Attack : ");
            bool iskenATK = int.TryParse(Console.ReadLine(), out int kenATK);

            Console.Write("ken Defence : ");
            bool iskenDef = int.TryParse(Console.ReadLine(), out int kenDef);

            // zen input stats
            Console.Write("zen Health : ");
            bool iszenHp = int.TryParse(Console.ReadLine(), out int zenHp);

            Console.Write("zen Attack : ");
            bool iszenATK = int.TryParse(Console.ReadLine(), out int zenATK);

            Console.Write("zen Defence : ");
            bool iszenDef = int.TryParse(Console.ReadLine(), out int zenDef);

            // Check if player input valid
            bool allkenValid = iskenHp && iskenATK && iskenDef;
            bool allzenValid = iszenHp && iszenATK && iszenDef;
            Console.WriteLine($"Stat Validdation: Ken: {allkenValid}, Zen: {allzenValid}");
            Console.WriteLine($"[Ken]   HP: {kenHp} ATK: {kenATK} DEF: {kenDef}");
            Console.WriteLine($"[Zen]   HP: {zenHp} ATK: {zenATK} DEF: {zenDef}");

            // Before fighting: Ken drink a potion 
            int potionHeal = 8;
            //1 
            kenHp = kenHp + potionHeal;
            //2 
            kenHp += potionHeal; //ใช้ตัวนี้ดีสุด
            Console.WriteLine($"\nKen drink a potion, Healling {potionHeal}. health is now {kenHp}.");
            
            // คำนวณ damage normal attack Arithmetic + Math
            int normalDamage = Math.Max(0, kenATK - zenDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

            // คำนวณ power attack Predence ลำดับคำนวณ คูณ ก่อนที่จะ ลบ
            int powerDamage  = Math.Max(0, kenATK * 2 - zenDef); // * มาก่อน - ไม่ต้องมี()
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            int counterDamage = Math.Max(0, zenATK - kenDef);
            Console.WriteLine($"Zen Counter Attack deal: {counterDamage} DMG");

            //คำนวณ Cri Chance
            Random rng = new Random();
            int roll = rng.Next( 1, 101 ); // สุ่ม cri 1-100 
            bool isCrit = roll <= 10; //10% ที่จะคริ
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; //โอกาส 10% ติดคริ เลชได้1 ไม่ติดได้0
            Console.WriteLine($"\nCtirical hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} DMG");
        }
    }
}
