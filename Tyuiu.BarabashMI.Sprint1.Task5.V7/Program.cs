using Tyuiu.BarabashMI.Sprint1.Task5.V7.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
        Console.WriteLine("* Задание #5                                                               *");
        Console.WriteLine("* Вариант #7                                                               *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                     *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток         *");
        Console.WriteLine("* до того момента когда часовая стрелка повернулась на f градусов          *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");
        double f;
        Console.WriteLine("Введите число f:");
        f = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.AngleToHoursMinutes(f));





        Console.ReadKey();
    }
}