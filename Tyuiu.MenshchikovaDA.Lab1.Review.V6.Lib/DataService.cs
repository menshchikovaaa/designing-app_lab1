using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MenshchikovaDA.Lab1.Review.V6.Lib
{
    public class DataService
    {
       public double Calc(double x, double y)
       {
            double x_squared = Math.Pow(x, 2);
            double first_argument = 1+1/x_squared;
            double second_argument = Math.Pow(first_argument,x);
            double third_argument = 12*x_squared*y;
            
            double z = second_argument-third_argument;
            
            return Math.Round(z, 3);
       }
    }
}
