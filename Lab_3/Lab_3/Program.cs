using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_3
{
    public interface ILineSegment
    {
        Point P1{ get; set; }
        Point P2 { get; set; }
    }
    public interface ILineEquation
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }
    }
    class Line : ILineSegment, ILineEquation
    {
        Point L1;
        Point L2;
        double a, b, c;
        public Line()
        {

        }
        public Line(Point L1, Point L2)
        {
            this.L1 = L1;
            this.L2 = L2;
        }
        public Line(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Point P1 { get => L1; set => L1 = value; }
        public Point P2 { get => L2; set => L2 = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        /*
        Point P1
        {
            get { return L1; }
            set { L1 = value; }
        }
        Point ILineSegment.P1 { get => L1; set => L1 = value; }
        
        Point P2
        {
            get { return L2; }
            set { L2 = value; }
        }
        Point ILineSegment.P2 { get => L2; set => L2 = value; }
        */
        public void IsParallelS(Line line1)
        {
            bool isParallel = true;
            double slope1 = (P2.Y - P1.Y) / (P2.X - P1.X);
            double slope2 = (line1.P2.Y - line1.P1.Y) / (line1.P2.X - line1.P1.X);
            if(slope1 != slope2)
            {
                isParallel = false;
            }
            Console.WriteLine("Lines are parallel: " + isParallel);
        }
        public void IsPerpendicularS(Line line1)
        {
            bool isPerpendicular = true;
            double slope1 = (P2.Y - P1.Y) / (P2.X - P1.X);
            double slope2 = (line1.P2.Y - line1.P1.Y) / (line1.P2.X - line1.P1.X);
            if(slope1 + slope2 != 0)
            {
                isPerpendicular = false;
            }
            Console.WriteLine("Lines are perpendicular: " + isPerpendicular);
        }
        public void IsParallelE(Line line2)
        {
            bool isParallel = true;
            double slope = A / B - line2.A / line2.B;
            if (Math.Abs(slope) != 03)
            {
                isParallel = false;
            }
            Console.WriteLine("Lines are parallel: " + isParallel);
        }
        public void IsPerpendicularE(Line line2)
        {
            bool isPerpendicular = true;
            double slope = A * line2.A + B * line2.B;
            if (Math.Abs(slope) != 0)
            {
                isPerpendicular = false;
            }
            Console.WriteLine("Lines are perpendicular: " + isPerpendicular);
        }

    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Work of Vadym Rybchynchuk AP-21");
            Console.WriteLine("Variant 3");
            Console.WriteLine();

            byte select;
            do
            {
                Console.WriteLine("     ***");
                Console.WriteLine("1. Task 1 (Line with points - auto)");
                Console.WriteLine("2. Task 2 (Line with equation - auto)");
                Console.WriteLine("3. Task 3 (Line with equation - yourself)");
                Console.WriteLine("4. Task 4 (Line with points - yourself)");
                Console.WriteLine("0. To end the task");
                Console.WriteLine("     ***");
                select = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (select)
                {
                    case 1:
                        Line line11 = new Line(new Point(-4, 2), new Point(-1, -1));
                        Line line21 = new Line(new Point(-1, 4), new Point(2, 1));
                        line11.IsParallelS(line21);
                        line11.IsPerpendicularS(line21);
                        break;
                    case 2:
                        Line line12 = new Line(3, 5, 6);
                        Line line22 = new Line(8, 1, 10);
                        line12.IsParallelE(line22);
                        line12.IsPerpendicularE(line22);
                        break;
                    case 3:
                        Line line13 = new Line();
                        Line line23 = new Line();
                        Console.WriteLine("Enter the number of first eqyation:");
                        line13.A = Convert.ToDouble(Console.ReadLine());
                        line13.B = Convert.ToDouble(Console.ReadLine());
                        line13.C = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the number of second equation:");
                        line23.A = Convert.ToDouble(Console.ReadLine());
                        line23.B = Convert.ToDouble(Console.ReadLine());
                        line23.C = Convert.ToDouble(Console.ReadLine());
                        line13.IsParallelE(line23);
                        line13.IsPerpendicularE(line23);
                        break;
                    case 4:
                        Line line14 = new Line();
                        Line line24 = new Line();
                        Console.WriteLine("Enter the coordinates of first Point of 1st line:");
                        line14.P1 = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Enter the coordinates of second Point of 1st line:");
                        line14.P2 = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Enter the coordinates of first Point of 2st line:");
                        line24.P1 = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Enter the coordinates of second Point of 2st line:");
                        line24.P2 = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        line14.IsParallelS(line24);
                        line14.IsPerpendicularS(line24);
                        break;

                    default:
                        break;
                }
            }
            while (select != 0);
            Console.WriteLine("The End of The Program!");
        }   
    }
}
/*
        public interface ILineSegment
        {
            Point P1 { get; set; }
            Point P2 { get; set; }
        }

        // Інтерфейс для задання прямої за допомогою рівняння прямої Ax + By + C = 0
        public interface ILineEquation
        {
            double A { get; set; }
            double B { get; set; }
            double C { get; set; }
        }
        
        // Клас для виконання операцій з прямими на площині
        
        public class Line 
        { 
            
            // Визначає, чи є дві прямі паралельними
            
            public static bool IsParallel(ILineSegment line1, ILineSegment line2)
            {
                double slope1 = (line1.P2.Y - line1.P1.Y) / (line1.P2.X - line1.P1.X);
                double slope2 = (line2.P2.Y - line2.P1.Y) / (line2.P2.X - line2.P1.X);
                return Math.Abs(slope1 - slope2) < 1e-6;
            }

            // Визначає, чи є дві прямі перпендикулярними
            public static bool IsPerpendicular(ILineSegment line1, ILineSegment line2)
            {
                double slope1 = (line1.P2.Y - line1.P1.Y) / (line1.P2.X - line1.P1.X);
                double slope2 = (line2.P2.Y - line2.P1.Y) / (line2.P2.X - line2.P1.X);
                return Math.Abs(slope1 * slope2 + 1) < 1e-6;
            }

            // Визначає, чи є дві прямі паралельними
            public static bool IsParallel(ILineEquation line1, ILineEquation line2)
            {
                return Math.Abs(line1.A / line1.B - line2.A / line2.B) < 1e-6;
            }

            // Визначає, чи є дві прямі перпендикулярними
            public static bool IsPerpendicular(ILineEquation line1, ILineEquation line2)
            {
                return Math.Abs(line1.A * line2.A + line1.B * line2.B) < 1e-6;
            }
        }*/