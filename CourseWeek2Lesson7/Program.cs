using System;

namespace CourseWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
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


    }
}
