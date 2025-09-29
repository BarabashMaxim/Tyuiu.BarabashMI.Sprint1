using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BarabashMI.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            char cr = Convert.ToChar(value);
            int crCode = Convert.ToInt32(cr);
            return ($"Символ: {cr} Код: {crCode}");
        }
    }
}
