using System;
using System.Diagnostics.CodeAnalysis;

namespace CourseWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise7();
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

        private static void Exercise5()
        {
            /* 5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
                    Dane testowe : 21
                Rezultat w terminalu :
                    Możesz zostać posłem    */

            Console.Write("Podaj wiek kandydata aby otrzymać informację o jaki urząd może się ubiegać: ");
            int age = int.Parse(Console.ReadLine());
            string result = string.Empty;
            if (age >= 35) result += "Kandydat może ubiegać się o urząd Prezydenta RP";
            if (age >= 30) result += result.Length == 0 ? "Kandydat może ubiegać się o urząd Senatora" : " lub Senatora";
            if (age >= 21) result += result.Length == 0 ? "Kandydat może ubiegać się o urząd Posła na Sejm" : " lub Posła na Sejm";
            result += result.Length != 0 ? "." : "Kandydat jest zbyt młody by pełnić urząd w państwie polskim.";
            Console.WriteLine(result);
        }


        public static void Exercise6()
        {
            /* 6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
                    Dane testowe : 140
                Rezultat w terminalu:
                    Jesteś krasnoludem      */

            Console.WriteLine("Podaj wzrost aby otrzymać informacje zwrotną o wymyślonej kategorii do której zostanie dopasowany: ");
            int height = int.Parse(Console.ReadLine());
            string result = height switch
            {
                _ when height > 180 => "wysoki",
                _ when height < 191 && height > 165 => "typowy",
                _ when height <= 165 && height >= 120 => "kobieta?",
                _ => "dziecko?"
            };
            Console.WriteLine($"Podany wzrost ({height}) określony został jako: {result}");
        }

        public static void Exercise7()
        {
            /* 7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
                    Dane testowe: 25, 63, 79
                Rezultat w terminalu :
                    79 jest największa z podanych       */

            Console.WriteLine("Podaj kolejno trzy liczby: ");
            int firstNb = int.Parse(Console.ReadLine());
            int secondNb = int.Parse(Console.ReadLine());
            int thirdNb = int.Parse(Console.ReadLine());

            int highestNb = firstNb >= secondNb ? (firstNb >= thirdNb ? firstNb : secondNb >= thirdNb ? secondNb : thirdNb ) : (secondNb >= thirdNb ? secondNb : thirdNb);
            Console.WriteLine($"{highestNb} jest największą z podanych liczb.");
        }

    }
}