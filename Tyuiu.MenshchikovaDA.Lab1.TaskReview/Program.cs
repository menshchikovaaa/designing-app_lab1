using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshchikovaDA.Lab1.Review.V6.Lib;

namespace Tyuiu.MenshchikovaDA.Lab1.TaskReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Лабораторная работа #1 | Выполнил: Менщикова Д.А. | НТм-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #1                                                  *");
            Console.WriteLine("* Тема: Базовые навыки создания консольных приложений по методологии TDD. *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Менщикова Дарья Андреевна | НТм-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("* Ответ округлить до трех знаков после запятой.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значение X:                                                     *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите значение Y:                                                     *");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calc(x, y));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
