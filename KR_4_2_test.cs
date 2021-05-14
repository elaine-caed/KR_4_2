using System;

namespace KR_4_2
{
    class Program
    {
        struct Point
        {
            public double x; //значення х
            public double y; //значення у
        }
        struct Circle
        {
            public double R; //радіус 
        }
        struct Figure
        {
            public Point PointF;
            public Circle CircleF;
            public float[] Figures;
            public double Diameter;
        }
        static void Main(string[] args)
        {
            int count = 1;
            Figure[] F1 = new Figure[2];
            for (int i = 0; i < 2; i++)
            {
                F1[i].Figures = new float[2];
            }
            F1[0].PointF.x = 1;
            Console.WriteLine($"x: {F1[0].PointF.x}");
            F1[0].PointF.y = 1;
            Console.WriteLine($"y: {F1[0].PointF.y}");
            F1[0].CircleF.R = 3;
            Console.WriteLine($"R: {F1[0].CircleF.R}");

            F1[1].PointF.x = 5;
            Console.WriteLine($"x: {F1[1].PointF.x}");
            F1[1].PointF.y = 5;
            Console.WriteLine($"y: {F1[1].PointF.y}");
            F1[1].CircleF.R = 4;
            Console.WriteLine($"R: {F1[1].CircleF.R}");
            F1[0].Diameter = Math.Pow((Math.Pow((F1[0].PointF.y - F1[1].PointF.y), 2) + Math.Pow((F1[0].PointF.x - F1[1].PointF.x), 2)), 0.5);//шукаємо відстань між центрами кіл щоб з'ясувати чи вони перетинаються
            if (F1[0].Diameter <= (F1[0].CircleF.R + F1[1].CircleF.R) && F1[0].Diameter >= Math.Abs(F1[0].CircleF.R - F1[1].CircleF.R))
            {
                Console.WriteLine("Circles 1 and 2 intersect");
                count++;
            }
            else
            {
                Console.WriteLine("Circles 1 and 2 don't intersect");
            }
            Console.WriteLine($"Number of intersecting circles: {count}");
        }
    }
}

