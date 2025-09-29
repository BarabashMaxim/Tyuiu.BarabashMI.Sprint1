using Tyuiu.BarabashMI.Sprint1.Task6.V1.Lib;

class Program
{
    
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
        Console.WriteLine("* Задание #6                                                               *");
        Console.WriteLine("* Вариант #1                                                               *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа.*");
        Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.   *");
        Console.WriteLine("* Рекомендуемый вид экрана во время выполнения программы приведен ниже.    *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");
        string str;
        Console.WriteLine("Введите символ и нажмите <Enter>.");
        Console.WriteLine("Для завершения введите точку.");
        str = Convert.ToString(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        if (str == ".")
            Environment.Exit(0);
        else
            Console.WriteLine(ds.SymbolCode(str));






        Console.ReadKey();
    }
}
