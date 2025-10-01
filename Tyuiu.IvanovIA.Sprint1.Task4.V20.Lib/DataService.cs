﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovIA.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((1 + x) / Math.Abs(x - Math.Sqrt(2 + y)),3);
            return res;
        }
    }
}
