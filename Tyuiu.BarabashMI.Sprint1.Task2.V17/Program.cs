using Tyuiu.BarabashMI.Sprint1.Task2.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
        Console.WriteLine("* Задание #2                                                               *");
        Console.WriteLine("* Вариант #17                                                              *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        int x;
        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Часов = " + ds.ConvertMinutesToHours(x));



        Console.ReadKey();
    }
}