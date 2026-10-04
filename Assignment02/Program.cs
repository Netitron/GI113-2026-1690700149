/*
* Student ID : 1690700149
* Name       : Natitorn Saisopon
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment02
{
    class Program
    {
        const double SMELT_RATE = 0.50;
        const double SALVAGE_RATE = 0.65;
        const double MAX_AMOUNT = 200;

        static void Main(string[] args)
        {
            Console.WriteLine("====== SILVER FORGE ======");
            Console.WriteLine("S : Smelt Silver Ore");
            Console.WriteLine("B : Breakdown Silver Ingot");
            Console.WriteLine("Smelt Rate : " + SMELT_RATE);
            Console.WriteLine("Salvage Rate : " + SALVAGE_RATE);

            Console.Write("Choose Menu : ");
            char menu;

            if (!char.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Invalid menu.");
                return;
            }

            menu = char.ToUpper(menu);

            switch (menu)
            {
                case 'S':
                case 'B':
                    break;

                default:
                    Console.WriteLine("Invalid menu.");
                    return;
            }

            Console.Write("Enter amount : ");
            double amount;

            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0.");
                return;
            }

            if (amount > MAX_AMOUNT)
            {
                Console.WriteLine("Amount is over the limit.");
                return;
            }

            double result;

            switch (menu)
            {
                case 'S':
                    result = amount * SMELT_RATE;
                    Console.WriteLine(
                        amount.ToString("F2") +
                        " Silver Ore -> " +
                        result.ToString("F2") +
                        " Silver Ingot"
                    );
                    break;

                default:
                    result = amount / SALVAGE_RATE;
                    Console.WriteLine(
                        amount.ToString("F2") +
                        " Silver Ingot -> " +
                        result.ToString("F2") +
                        " Silver Ore"
                    );
                    break;
            }

            Console.WriteLine("Forge complete.");
        }
    }
}
