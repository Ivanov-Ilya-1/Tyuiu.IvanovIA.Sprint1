using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovIA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int d = Convert.ToInt32(Math.Floor((x * 10) % 10));
            return d;
        }
    }
}
