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
            //double bigeer = Math.Max((Math.Max(top1, top2)), top3);
            //double min = Math.Min((Math.Min(top1, top2)), top3);
            ////double sred = 0;

            //if ( top1 == bigeer && top2 == min)
            //{
            //    sred = top3;
            //}
            //else if (top2 == bigeer && top3 == min)
            //{

            //}


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
                sides.Sort();
                if (Math.Pow(sides[0], 2)<(Math.Pow(sides[1], 2)+ Math.Pow(sides[2], 2)))
                {
                    Console.WriteLine("Остроугольный");
                    double P = (Math.Sqrt(3) / 4) * (Math.Pow(top1, 2));
                    Console.Write("Площадь равностороннего = " + P);
                }
                else if (Math.Pow(sides[0], 2) == (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)))
                {
                    double h = 0;
                    double P;
                    Console.WriteLine("Прямоугольный");
                    if (top1 == top2)
                    {
                        h = Math.Sqrt(Math.Pow(top1, 2) - (Math.Pow(top3, 2) / 4));
                        P = 0.5 * top3 * h;
                    }
                    else if (top2 == top3)
                    {
                        h = Math.Sqrt(Math.Pow(top2, 2) - (Math.Pow(top1, 2) / 4));
                        P = 0.5 * top1 * h;
                    }
                    else
                    {
                        h = Math.Sqrt(Math.Pow(top1, 2) - (Math.Pow(top2, 2) / 4));
                        P = 0.5 * top2 * h;
                    }
                    Console.Write("Площадь равнобедренного = " + P);
                }
                else if (Math.Pow(sides[0], 2) > (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)))
                {
                    Console.WriteLine("Тупоугольный");
                    double p_ = (top1 + top2 + top3) / 2;
                    double P = Math.Sqrt(p_ * (p_ - top1) * (p_ - top2) * (p_ - top3));
                    Console.Write("Площадь разносторонного = " + P);
                }
            }
        }
    }
}
