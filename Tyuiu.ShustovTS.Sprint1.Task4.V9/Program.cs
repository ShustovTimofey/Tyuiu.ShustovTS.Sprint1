using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShustovTS.Sprint1.Task4.V9.Lib;

namespace Tyuiu.ShustovTS.Sprint1.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шустов Т.С. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУб-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  вычисляет результат по формуле и печатает его на экране.               *");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Log10( x * y ) / Sqrt(1 + y * y) = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}