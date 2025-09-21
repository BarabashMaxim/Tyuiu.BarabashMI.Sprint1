﻿using Tyuiu.BarabashMI.Sprint1.Task1.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
        Console.WriteLine("* Задание #1                                                               *");
        Console.WriteLine("* Вариант #3                                                               *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователся исходные данные, *");
        Console.WriteLine("* вычисляет рузультат по формуле (x-y)/(x+3)+3 и печатает его на экране.   *");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        double x,y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));






        Console.ReadKey();
    }
}
