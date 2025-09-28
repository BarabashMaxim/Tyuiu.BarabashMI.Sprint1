using Tyuiu.BarabashMI.Sprint1.Task3.V10.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
        Console.WriteLine("* Задание #3                                                               *");
        Console.WriteLine("* Вариант #10                                                              *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры           *");
        Console.WriteLine("* дробное число в денежный формат.                                         *");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        double x;
        Console.WriteLine("Введите число:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.NumberToMoney(x));





        Console.ReadKey();
    }
}