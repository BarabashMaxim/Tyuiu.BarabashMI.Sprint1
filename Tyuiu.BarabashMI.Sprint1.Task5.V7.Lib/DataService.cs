using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BarabashMI.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            f /= 30;
            f = Math.Floor(f);
            return Convert.ToInt32(f);
        }
    }
}
