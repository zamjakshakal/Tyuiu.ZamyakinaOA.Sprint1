﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task1.V1.Lib
{
    public class DataService : ISprint1Task1V1
    {
        public double Calculate(double x, double y, double a)
        {
            return x / 3 / y + 6 * a;
        }
    }
}
