using System;

namespace CourseWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise4();
        }


        public static void Exercise1()
        {
            /* 1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
                    Dane testowe:
                    a : 5
                    b : 5
                Rezultat w terminalu :
                    5 i 5 są równe              */

            int first = 5;
            int second = 5;

            if (first == second)
            {
                Console.WriteLine($"{first} i {second} są równe.");
            }
        }

        public static int Exercise2()
        {
            /* 2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
                    Dane testowe : 15
                Rezultat w terminalu :
                    15 jest liczbą nieparzystą      */

            /* ver 1
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} jest liczbą nieparzystą.");
            }   */

            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0) Console.WriteLine($"{number} jest liczbą nieparzystą.");
            number = number % 2 != 0 ? number : Exercise2();
            return number;
        }

        private static void Exercise3()
        {
            /* 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
                    Dane testowe : 14
                Rezultat w terminalu :
                    14 jest liczbą dodatnią     */

            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            string result = number switch
            {
                _ when number > 0 => $"{number} jest liczbą dodatnią.",
                _ when number < 0 => $"{number} jest liczbą ujemną.",
                _ => $"{number} wynosi zero."
            };
            Console.WriteLine(result);
        }

        private static void Exercise4()
        {
            /* 4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
                    Dane testowe : 2016
                Rezultat w terminalu :
                    2016 jest rokiem przestępnym    */

            Console.Write("Podaj 4 cyfry roku: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? true : false;
            string result = isLeapYear switch
            {
                true => "jest rokiem przestępnym.",
                _ => "nie jest rokiem przestępnym."
            };
            Console.WriteLine($"{year} {result}");
            
        }


    }
}
