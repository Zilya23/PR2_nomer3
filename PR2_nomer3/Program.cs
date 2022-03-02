using System;
using System.Collections.Generic;

namespace PR2_nomer3
{
    class Program
    {
        static void Main(string[] args)
        {
            double top1 = 0;
            double top2 = 0;
            double top3 = 0;
            try
            {
                top1 = Convert.ToDouble(Console.ReadLine());
                top2 = Convert.ToDouble(Console.ReadLine());
                top3 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите числа!");
                return;
            }

            if (top1 <= 0 || top2 <= 0 || top3 <= 0)
            {
                Console.WriteLine("Сторона треугольника не может быть меньше или равна нулю");
            }
            else if ((top1 + top2 < top3) || (top2 + top3 < top1) || (top1 + top3 < top2))
            {
                Console.WriteLine("Сумма двух сторон треугольника не может быть меньше третьей стороны");
            }
            else
            {
                List<double> sides = new List<double>() { top1, top2, top3 };
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine(sides[i]);
                //}
                sides.Sort();
                if (Math.Pow(sides[2], 2)<(Math.Pow(sides[1], 2)+ Math.Pow(sides[0], 2)))
                {
                    Console.WriteLine("Остроугольный");
                    double p_ = (top1 + top2 + top3) / 2;
                    double P = Math.Sqrt(p_ * (p_ - top1) * (p_ - top2) * (p_ - top3));
                    Console.Write("Площадь остроугольного = " + P);
                }
                else if (Math.Pow(sides[2], 2) == ((Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2))))
                {
                    Console.WriteLine("Прямоугольный");
                    double p_ = (top1 + top2 + top3) / 2;
                    double P = Math.Sqrt(p_ * (p_ - top1) * (p_ - top2) * (p_ - top3));
                    Console.Write("Площадь прямоугольного = " + P);
                }
                else if (Math.Pow(sides[2], 2) > (Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2)))
                {
                    Console.WriteLine("Тупоугольный");
                    double p_ = (top1 + top2 + top3) / 2;
                    double P = Math.Sqrt(p_ * (p_ - top1) * (p_ - top2) * (p_ - top3));
                    Console.Write("Площадь тупоугольного = " + P);
                }
            }
        }
    }
}
