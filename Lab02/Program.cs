/*
 * Student ID : 1690700149
 * Name       : Natitorn Saisopon
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
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");

            //ตัวละครที่ 1: อัศวิน
            string p1Name = "KIMYONG";
            int p1Hp = 900;
            float p1Armor = 95.5f;
            char p1Grade = 'S';
            bool p1IsAlive = true;

            Console.WriteLine($"Name: {p1Name}");
            Console.WriteLine($"HP: {p1Hp}");
            Console.WriteLine($"Armor: {p1Armor}");
            Console.WriteLine($"Grade: {p1Grade}");
            Console.WriteLine($"Is Alive: {p1IsAlive}");

            //ตัวละครที่ 2: นักเวช
            string p2Name = "KITAE";
            int p2Mana = 450;
            double p2MaqicPower = 150;
            char p2Element = 'F'; // F = Fire
            bool p2IsAlive = true;
            char p1Grade = 'A';

            Console.WriteLine($"Name: {p2Name}");
            Console.WriteLine($"Mana: {p2Mana}");
            Console.WriteLine($"Magic Power: {p2MaqicPower}");
            Console.WriteLine($"Element: {p2Element}");
            Console.WriteLine($"Is Alive: {p2IsAlive}");
            Console.WriteLine($"Grade: {p1Grade}");

            //ตัวละครที่ 3: นักธนู
            string p3Name = "GUNPARK";
            int p3Arrows = 45;
            float p3speed = 75;
            double p3Accuracy = 120;
            bool p3IsStealth = true;
            char p1Grade = 'A';

            Console.WriteLine($"Name: {p3Name}");
            Console.WriteLine($"Arrows: {p3Arrows}");
            Console.WriteLine($"speed: {p3speed}");
            Console.WriteLine($"Accuracy: {p3Accuracy}");
            Console.WriteLine($"Is Stealth: {p3IsStealth}");
            Console.WriteLine($"Grade: {p1Grade}");

            //ตัวละครที่4: นักบวช
            string p4Name = "JINSONG";
            int p4HealPower = 100;
            float p4ReqenRate = 5f;
            bool p4IsActive = true;
            char p1Grade = 'A';

            Console.WriteLine($"Name: {p4Name}");
            Console.WriteLine($"HealPower: {p4HealPower}");
            Console.WriteLine($"ReqenRate: {p4ReqenRate}");
            Console.WriteLine($"Rank: {p4Rank}");
            Console.WriteLine($"Is Active: {p4IsActive}");
            Console.WriteLine($"Grade: {p1Grade}");
        }
    }
}
