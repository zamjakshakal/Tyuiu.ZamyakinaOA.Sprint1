using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            return Math.Round(x - (7 * x * x) / (x * x * x) + Math.Sin(x) + Math.Abs((x * x * x * x) - (x * x * x * x * x)), 3);
        }
    }
}
