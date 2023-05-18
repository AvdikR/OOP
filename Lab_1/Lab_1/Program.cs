using System;

namespace Lab_1
{
    class TSquare
    {
        protected double side1;
        protected double side2;

        public TSquare()
        {
            
        }
        public TSquare(double length, double height)
        {
            this.side1 = length;
            this.side2 = height;
        }
        public TSquare(TSquare added)
        {
            this.side1 = added.side1;
            this.side2 = added.side2;
        }

        public virtual void InputElements()
        {
            Console.WriteLine("Enter the sides of the TSquare");
            try
            {
                Console.Write("First(length) side = ");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Second(height) side = ");
                side2 = Convert.ToDouble(Console.ReadLine());
                if (side1 != side2)
                {
                    throw new Exception("Error. The sides are diffrent. Need to change one of the sides!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                InputElements();
            }
            finally
            {
                Console.WriteLine("All is well!");
            }


        }
        public void OutputElements()
        {
            Console.WriteLine("Length of Square = " + side1);
            Console.WriteLine("Height of Square = " + side2);
        }
        public void SearchArea()
        {
            Console.WriteLine("Serching the area of TSquare:");
            double S;
            S = side1 * side2;
            Console.WriteLine("Area = " + S);
        }
        public void SearchPerimeter()
        {
            Console.WriteLine("Searching the perimeter of TSquare:");
            double P;
            P = 2 * (side1 + side2);
            Console.WriteLine("Perimeter = " + P);

        }
        public void ComprassionWithAnother(TSquare p)
        {
            Console.WriteLine("Comprassion with another square:");
            p.OutputElements();
            bool com;
            if (side1 == p.side1 && side2 == p.side2)
            {
                com = true;
            }
            else
            {
                com = false;
            }

            Console.WriteLine("TRengles are similar: " + com);
            if (side1 > p.side1 || side2 > p.side2)
            {
                Console.WriteLine("The first TSquare is bigger than second");
            }
            if (p.side1 > side1 || p.side2 > side2)
            {
                Console.WriteLine("The second TSquare is bigger than first");
            }

        }
        public static TSquare operator +(TSquare a, TSquare b)
        {
            return new TSquare(a.side1 + b.side1, a.side2 + b.side2);
        }
        public static TSquare operator -(TSquare a, TSquare b)
        {
            return new TSquare(Math.Abs(a.side1 - b.side1), Math.Abs(a.side2 - b.side2));
        }
        public static TSquare operator *(TSquare a, int n)
        {
            return new TSquare(a.side1 * n, a.side2 * n);
        }



    }
    class TCube : TSquare
    {
        double side3;

        public TCube()
        {
            
        }
        public TCube(double length, double height, double width)
        {
            this.side1 = length;
            this.side2 = height;
            this.side3 = width;
        }
        public TCube(TCube added)
        {
            this.side1 = added.side1;
            this.side2 = added.side2;
            this.side3 = added.side3;
        }
        public override void InputElements()
        {
            Console.WriteLine("Enter the sides of the cube");
            try
            {
                Console.Write("First(length) side = ");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Second(height) side = ");
                side2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Third(width) side = ");
                side3 = Convert.ToDouble(Console.ReadLine());
                if (side1 != side2 || side1 != side3 || side2 != side3)
                {
                    throw new Exception("Error. The sides are diffrent. Need to change one of the sides!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                InputElements();
            }
            finally
            {
                Console.WriteLine("All is well");
            }
        }
        public void OutputElementsCube()
        {
            Console.WriteLine("Length of cube = " + side1);
            Console.WriteLine("Height of cube = " + side2);
            Console.WriteLine("Width of cube = " + side3);
        }
        public void SearchAreaCube()
        {
            Console.WriteLine("Serching the area of cube:");
            double S;
            S = 6 * Math.Pow(side3, 2);
            Console.WriteLine("Area = " + S);
        }
        public void SearchPerimeterCube()
        {
            Console.WriteLine("Searching the perimeter of cube:");
            double P;
            P = 12 * side3;
            Console.WriteLine("Perimeter = " + P);

        }
        public void SearchVolume()
        {
            Console.WriteLine("Searching the volume");
            double V;
            V = Math.Pow(side3, 3);
            Console.WriteLine("Volume = " + V);
        }

        public static TCube operator +(TCube a, TCube b)
        {
            return new TCube(a.side1 + b.side1, a.side2 + b.side2, a.side3 + b.side3);
        }
        public static TCube operator -(TCube a, TCube b)
        {
            return new TCube(Math.Abs(a.side1 - b.side1), Math.Sqrt(a.side2 - b.side2), Math.Sqrt(a.side3 - b.side3));
        }
        public static TCube operator *(TCube a, int n)
        {
            return new TCube(a.side1 * n, a.side2 * n, a.side3 * n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work of Rybchynchuk Vadym PP-21");
            Console.WriteLine("Variant 3");
            Console.WriteLine("Enter the main(first) figure:");

            TSquare form = new TSquare();
            TSquare form1;

            form.InputElements();
            form.OutputElements();

            Console.WriteLine("Enter the second figure: 1-Input Yourself/others-Input with constructor");
            byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 1)
            {
                form1 = new TSquare();
                form1.InputElements();
            }
            else
            {
                form1 = new TSquare(4, 4);
            }

            Console.WriteLine();
            byte select;
            do
            {
                Console.WriteLine("        ***");
                Console.WriteLine("1. Searching of area of TSquare");
                Console.WriteLine("2. Searching of perimeter of TSquare");
                Console.WriteLine("3. Comprassion with another TSquare");
                Console.WriteLine("4. Reload operators");
                Console.WriteLine("        ***");
                select = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (select)
                {
                    case 1:
                        form.SearchArea();
                        break;

                    case 2:
                        form.SearchPerimeter();
                        break;
                    case 3:
                        form.ComprassionWithAnother(form1);
                        break;
                    case 4:
                        Console.Write("Choose the type of reload(1.+;2.-;3.*n): ");
                        byte t = Convert.ToByte(Console.ReadLine());
                        if (t == 1)
                        {
                            Console.WriteLine(form + form1);
                            form = form + form1;
                        }
                        if (t == 2)
                        {
                            Console.WriteLine(form - form1);
                            form = form - form1;
                        }
                        if (t == 3)
                        {
                            Console.Write("Enter the number: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            form = form * n;
                        }
                        form.OutputElements();
                        break;

                    default:
                        break;
                }
            }
            while (select != 0);

            Console.WriteLine("Enter the cube:");
            TCube cube = new TCube();
            TCube cube1 = new TCube(3, 3, 3);
            cube.InputElements();
            Console.WriteLine();
            cube.OutputElementsCube();
            Console.WriteLine();
            cube.SearchAreaCube();
            Console.WriteLine();
            cube.SearchPerimeterCube();
            Console.WriteLine();
            cube.SearchVolume();
            Console.WriteLine();
            Console.Write("Choose the type of reload(1.+;2.-;3.*n): ");
            byte s = Convert.ToByte(Console.ReadLine());
            if (s == 1)
            {
                Console.WriteLine(cube + cube1);
                cube = cube + cube1;
            }
            if (s == 2)
            {
                Console.WriteLine(cube - cube1);
                cube = cube - cube1;
            }
            if (s == 3)
            {
                Console.Write("Enter the number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                cube = cube * n;
            }
            cube.OutputElementsCube();

            Console.WriteLine();
            Console.WriteLine("The END of The Program");
        }
    }
}
