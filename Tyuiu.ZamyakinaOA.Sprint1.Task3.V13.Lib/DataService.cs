using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int num;
                num = (int)number;
            int a = num / 100;
            int b = (num % 100) / 10;
            int c = num % 10;
            return Math.Round((double)a * b * c, 3);

        }
    }
}
