using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint2.Task7.V11.Lib;

namespace Tyuiu.KaidalovIG.Sprint2.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменных X, Y");
            double x, y;
            y = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Кайдалов И. Г. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: 2.7   Добавление к решению итоговых проектов по спринту           *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кайдалов Илья Григорьевич  | СМАРТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения)" +
                " и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(x + " " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
