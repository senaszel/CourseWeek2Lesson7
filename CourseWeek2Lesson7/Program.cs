﻿using System;

namespace CourseWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2();
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


    }
}