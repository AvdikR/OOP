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
                        //Створення двух прямих за допомогою ккординат(точок) власноруч
                        Line line13 = new Line();
                        Line line23 = new Line();

                        try
                        {
                            Console.WriteLine("Enter the number of the first equation:");
                            line13.A = Convert.ToDouble(Console.ReadLine());
                            line13.B = Convert.ToDouble(Console.ReadLine());
                            line13.C = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter the number of the second equation:");
                            line23.A = Convert.ToDouble(Console.ReadLine());
                            line23.B = Convert.ToDouble(Console.ReadLine());
                            line23.C = Convert.ToDouble(Console.ReadLine());

                            line13.IsParallelE(line23);
                            line13.IsPerpendicularE(line23);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter valid numbers for the coefficients.");
                        }

                        break;
                    case 4:
                        //Створення двух прямих за допомогою рівнянь власноруч
                        Line line14 = new Line();
                        Line line24 = new Line();
                        
                        try
                        {
                            Console.WriteLine("Enter the coordinates of the first Point of the 1st line:");
                            double x1 = Convert.ToDouble(Console.ReadLine());
                            double y1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter the coordinates of the second Point of the 1st line:");
                            double x2 = Convert.ToDouble(Console.ReadLine());
                            double y2 = Convert.ToDouble(Console.ReadLine());

                            line14.P1 = new Point(x1, y1);
                            line14.P2 = new Point(x2, y2);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter valid coordinates.");
                        }

                        try
                        {
                            Console.WriteLine("Enter the coordinates of the first Point of the 1st line:");
                            double x1 = Convert.ToDouble(Console.ReadLine());
                            double y1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter the coordinates of the second Point of the 1st line:");
                            double x2 = Convert.ToDouble(Console.ReadLine());
                            double y2 = Convert.ToDouble(Console.ReadLine());

                            line24.P1 = new Point(x1, y1);
                            line24.P2 = new Point(x2, y2);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter valid coordinates.");
                        }
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

