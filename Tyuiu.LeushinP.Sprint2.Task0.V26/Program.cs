﻿using System;
using Tyuiu.LeushinP.Sprint2.Task0.V26.Lib;


// Операции сравнения (-=, !-, <, >,<=, >=)



namespace Tyuiu.LeushinP.Sprint2.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических       *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):         *");
            Console.WriteLine("* (False, False, False, True, True, True), при x = 1045, y = 975           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x = 1045;
            int y = 975;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                {
                    Console.WriteLine(res[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Для завершения нажмите любую клавишу...                                     ");
                Console.ReadKey();
            }
        }
    }
}