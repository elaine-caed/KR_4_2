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
            public double R;
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
            Console.Write("Enter number of circles: ");
            string n1 = Console.ReadLine();
            int n = Convert.ToInt32(n1);
            Figure[] F1 = new Figure[n];
            for (int i = 0; i < n; i++)
            {
                F1[i].Figures = new float[n];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("x: ");
                string a = Console.ReadLine();
                int numberx = Convert.ToInt32(a);
                F1[i].PointF.x = numberx;
                Console.Write("y: ");
                string b = Console.ReadLine();
                int numbery = Convert.ToInt32(b);
                F1[i].PointF.y = numbery;
                Console.Write("R: ");
                string c = Console.ReadLine();
                int numberR = Convert.ToInt32(c);
                F1[i].CircleF.R = numberR;
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                F1[i - 1].Diameter = Math.Pow((Math.Pow((F1[i - 1].PointF.y - F1[i].PointF.y), 2) + Math.Pow((F1[i - 1].PointF.x - F1[i].PointF.x), 2)), 0.5);//відстань між центрами кіл
                if (F1[i - 1].Diameter <= (F1[i - 1].CircleF.R + F1[i].CircleF.R) && F1[i - 1].Diameter >= Math.Abs(F1[i - 1].CircleF.R - F1[i].CircleF.R))//перевіряємо чи перетинаютьс кола
                {
                    Console.WriteLine($"Circles {i} and {i + 1} intersect");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Circles {i} and {i + 1} don't intersect");
                }
                Console.WriteLine($"Number of intersecting circles: {count}");
            }
        }
    }
}
