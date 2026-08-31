namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // output แสดงตัวแปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nName: {bossName}\nRank: {rank}\nLevel: {level}/{MaxLevel}\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            //ทำImplicit int -> double
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // Int->> Double แปลงแบบไม่ cast ใส่ค่าได้เลย
            Console.WriteLine();

            //ทำทศนิยม
            Console.WriteLine("-----Exact HP Percent(no integer truncation)------");
            double hpPercent = currentHpDouble * 100 / maxHp;//int หาร int
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            //ทำ Explicit โดยการ Casting (Float) AttackPower ->> Int
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;   // แปลงข้อมูลโดยการ Cast
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            Console.WriteLine();

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = (int)Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Convert rounded) : {critConvert}");
        }
    }
}
    