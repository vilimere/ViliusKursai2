using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.Write("Iveskite pirma skaicius: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite antra skaicius: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite trecia skaicius: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is Jusu ivestu skaiciu didziausias yra: " + Max(sk1, sk2, sk3));

            Console.WriteLine(InRange(sk1, sk2, sk3));

            Console.WriteLine("Ar pirmas skaicius yra pirminis: " + IsPrimal(sk1));

            Console.WriteLine("Random skaicius D20: " + D20());
        }
        static string InRange(int sk1, int sk2, int sk3)
        {
            if (sk2 > sk1 && sk1 > sk3)
            {
                return $"Skaicius {sk1} yra tarp {sk2} ir {sk3}";
            }
            else if (sk3 > sk1 && sk1 > sk2)
            {
                return $"Skaicius {sk1} yra tarp {sk2} ir {sk3}";
            }
            else
            {
                return $"Skaicius {sk1} nera tarp {sk2} ir {sk3}";
            }
        }
        static int Max(int sk1, int sk2, int sk3)
        {
            if (sk1 > sk2 && sk1 > sk3)
            {
                return sk1;
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                return sk2;
            }
            else if (sk3 > sk1 && sk3 > sk1)
            {
                return sk3;
            }
            else

            { return 999999; }
        }

        static bool IsPrimal(int sk1)
        {
            

            for (int i = 2; i < sk1 / i; i++)
            {
                if (sk1 % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int D20()
        {
            Random rnd = new Random();

<<<<<<< HEAD
            rnd.Next(1, 21);

            return rnd.Next(1, 21);
=======
            rnd.Next(1, 20);

            return rnd.Next(1, 20);
>>>>>>> Adding3and4
        }
    }
}