using Tyuiu.BarabashMI.Sprint1.Task7.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
        Console.WriteLine("* Задание #7                                                               *");
        Console.WriteLine("* Вариант #1                                                               *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение           *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                    *");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");
        double a, b, c;
        Console.WriteLine("Введите число a:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число c:");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.Calculate(a, b, c));





        Console.ReadKey();
    }
}