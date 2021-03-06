﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace CourseWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise13();
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

            int highestNb = firstNb >= secondNb ? (firstNb >= thirdNb ? firstNb : secondNb >= thirdNb ? secondNb : thirdNb) : (secondNb >= thirdNb ? secondNb : thirdNb);
            Console.WriteLine($"{highestNb} jest największą z podanych liczb.");
        }

        public static void Exercise8()
        {
            /* 8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:
                    Wynik z Matury z matematyki powyżej 70
                    Wynik z fizyki powyżej 55
                    Wynik z chemii powyżej 45
                    Łączny wynik z 3 przedmiotów powyżej 180
                Albo
                    Wynik z matematyki i jednego przedmiotu powyżej 150
                    Dane testowe:
                    Matematyka 80, Fizyka 71, Chemia 0
                Rezultat w terminalu :
                    Kandydat dopuszczony do rekrutacji      */

            Console.WriteLine("Program udzieli informacji o możliwości wzięcia udziału w rekrutacji. Proszę podać następujące wyniki: ");
            Console.Write("Wynik z matury z matematyki: ");
            int mathGrade = int.Parse(Console.ReadLine());
            Console.Write("Wynik z matury z fizyki: ");
            int physicsGrade = int.Parse(Console.ReadLine());
            Console.Write("Wynik z matury z chemii: ");
            int chemistryGrade = int.Parse(Console.ReadLine());

            bool suitableForRecrutation = false;
            if (((mathGrade + physicsGrade + chemistryGrade) > 180) || (mathGrade + physicsGrade > 150) || (mathGrade + chemistryGrade > 150))
            {
                suitableForRecrutation = true;
            }
            string evaluationResponse = suitableForRecrutation == true ? "Kandydat dopuszczony do rekrutacji" : "Kandydat nie spełniający wymagań rekrutacyjnych";
            Console.WriteLine(evaluationResponse);
        }

        public static void Exercise9()
        {
            /* 9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
                    Temp < 0 – cholernie piździ
                    Temp 0 – 10 – zimno
                    Temp 10 – 20 – chłodno
                    Temp 20 – 30 – w sam raz
                    Temp 30 – 40 – zaczyna być słabo, bo gorąco
                    Temp >= 40 – a weź wyprowadzam się na Alaskę.
                Dane testowe : 41
                Rezultat w terminalu : a weź wyprowadzam się na Alaskę.     */

            Console.WriteLine("Podaj temperature: ");
            int temperature = int.Parse(Console.ReadLine());
            string desc = temperature switch
            {
                _ when temperature < 0 => "- Cholernie piździ.",
                _ when temperature >= 0 && temperature < 10 => "- Zimo.",
                _ when temperature >= 10 && temperature < 20 => "- Chłodno.",
                _ when temperature >= 20 && temperature < 30 => "- W sam raz.",
                _ when temperature >= 30 && temperature < 40 => "- Zaczyna być słabo, bo gorąco.",
                _ when temperature >= 40 => "-...a weź wyprowadzam się na Alaskę."
            };
            Console.WriteLine(desc);
        }

        public static void Exercise10()
        {
            /* 10. Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
                        Dane testowe : 40 55 65
                    Rezultat w terminalu :
                        Można zbudować trójkąt      */

            int firstNb = 40;
            int secondNb = 55;
            int thirdNb = 65;

            int highestNb = firstNb >= secondNb ? (firstNb >= thirdNb ? firstNb : secondNb >= thirdNb ? secondNb : thirdNb) : (secondNb >= thirdNb ? secondNb : thirdNb);

            bool isRectanglable = false;
            if (highestNb < (firstNb + secondNb + thirdNb - highestNb)) { isRectanglable = true; }

            string answer = isRectanglable == true ? "Można zbudować trójkąt" : "Nie można zbudować trójkąta";
            Console.WriteLine(answer);
        }

        public static void Exercise11()
        {
            /* 11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
                    Ocena Opis
                        6 Celujący
                        5 Bardzo dobry
                        4 Dobry
                        3 Dostateczny
                        2 Dopuszczający
                        1 Niedostateczny
                    Dane testowe : 3
                    Rezultat w terminalu : Dostateczny      */

            Console.Write("Podaj ocenę za pomocą liczby: ");
            int mark = int.Parse(Console.ReadLine());

            Grade grade = mark switch
            {
                1 => Grade.Niedostateczna,
                2 => Grade.Dopuszczająca,
                3 => Grade.Dostateczna,
                4 => Grade.Dobra,
                5 => Grade.BardzoDobra,
                6 => Grade.Celująca,
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(Grade)),
            };

            Console.WriteLine($"Ocena: {grade}");
        }

        public static void Exercise12()
        {
            /* 12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
                    Dane testowe : 4
                    Rezultat w terminalu : Czwartek     */

            Day day = new Day();
            Console.Write("Podaj numer dnia tygodnia a program wyświetli jego nazwę: ");
            day.Number = int.Parse(Console.ReadLine());
            day.Name = day.Number switch
            {
                1 => DayOfWeek.Monday,
                2 => DayOfWeek.Tuesday,
                3 => DayOfWeek.Wednesday,
                4 => DayOfWeek.Thursday,
                5 => DayOfWeek.Friday,
                6 => DayOfWeek.Saturday,
                7 => DayOfWeek.Sunday,
                _ => throw new ArgumentException(message: "non-existent day of the week", paramName: nameof(DayOfWeek))
            };

            var cultureInfo = new CultureInfo("pl-PL");
            Console.WriteLine($"{day.Number} dniem tygodnia jest {cultureInfo.DateTimeFormat.GetDayName(day.Name)}");
        }

        public static void Exercise13()
        {
            /* 13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
                        Podaj pierwszą liczbę:
                                …
                        Podaj drugą liczbę:
                                …
                        Podaj numer operacji do wykonania:
                            1. Dodawanie
                            2. Odejmowanie
                            3. Mnożenie
                            4. Dzielenie
                                …
                        Twój wynik to:          */

            Console.WriteLine("Prosty kalkulator");
            Console.WriteLine("Podaj pierwsza liczbę: ");
            double firstNb = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            double secondNb = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer operacji do wykonania:\r\n1. Dodawanie\r\n2. Odejmowanie\r\n3. Mnożenie\r\n4.Dzielenie");
            int choice = int.Parse(Console.ReadLine());
            double result = choice switch
            {
                1 => firstNb + secondNb,
                2 => firstNb - secondNb,
                3 => firstNb * secondNb,
                4 => firstNb / secondNb
            };
            Console.WriteLine($"Twój wynik to {result}");
        }


    }
}