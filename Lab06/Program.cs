/*
* Student ID : 1690700149
* Name       : Natitorn Saisopon
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

class lab6
{
    static void Main()
    {
        Console.WriteLine("[[=== KEN VS ZEN ===]]");
        Console.WriteLine("One Round Battle");
        Console.WriteLine();

        Console.Write("Enter KEN HP: ");
        bool ok1 = int.TryParse(Console.ReadLine(), out int heroHP);

        Console.Write("Enter ZEN HP: ");
        bool ok2 = int.TryParse(Console.ReadLine(), out int monsterHP);

        Console.Write("Enter KEN Damage: ");
        bool ok3 = int.TryParse(Console.ReadLine(), out int heroDamage);

        Console.Write("Enter ZEN Damage: ");
        bool ok4 = int.TryParse(Console.ReadLine(), out int monsterDamage);

        if (!ok1 || !ok2 || !ok3 || !ok4 ||
            heroHP <= 0 || monsterHP <= 0 ||
            heroDamage <= 0 || monsterDamage <= 0)
        {
            Console.WriteLine("Invalid input.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("--- KEN Turn ---+");
            Console.WriteLine("KEN attacks the ZEN!");

            monsterHP = monsterHP - heroDamage;

            if (monsterHP <= 0)
            {
                Console.WriteLine("Monster is defeated!");
                Console.WriteLine("KEN wins!");
            }
            else
            {
                Console.WriteLine("Monster HP: " + monsterHP);
                Console.WriteLine();
                Console.WriteLine("--- ZEN Turn ---");
                Console.WriteLine("ZEN attacks the KEN!");

                heroHP = heroHP - monsterDamage;

                if (heroHP <= 0)
                {
                    Console.WriteLine("KEN is defeated!");
                    Console.WriteLine("ZEN wins!");
                }
                else if (heroHP > 0 && monsterHP > 0)
                {
                    Console.WriteLine("KEN HP: " + heroHP);
                    Console.WriteLine("ZEN HP: " + monsterHP);
                    Console.WriteLine("The battle continues.");
                }
                else
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Game Over.");
    }
}