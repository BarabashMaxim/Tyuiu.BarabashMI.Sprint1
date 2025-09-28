using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BarabashMI.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            double roundnumber = Math.Round(number,3);
            string str = roundnumber.ToString();
            string[] numbers = str.Split(',');
            string n1 = numbers[0];
            string n2 = numbers[1];
            
            return n1 + " руб. " + n2 + " коп.";
        }
    }
}
