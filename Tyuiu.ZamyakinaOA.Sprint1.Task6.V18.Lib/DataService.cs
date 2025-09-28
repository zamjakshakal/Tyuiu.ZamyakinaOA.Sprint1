using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            foreach (var ch in value)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }
    }
}
