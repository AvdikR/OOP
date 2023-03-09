using System;
using System.Collections.Generic;

namespace Lab_2
{
    interface ArrayMenu
    {

    }
    class ODArray
    {
        public int size;
        public int[] array;

        public void InputElements()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            Console.WriteLine("Enter the elements(coordinates) of the array:");
            for (int i = 0; i < size; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void OutputElements()
        {
            Console.WriteLine("Main Array:");
            Console.Write("( ");
            for (int i = 0; i < size; i++)
            {

                Console.Write(array[i]);
                Console.Write(" ");

            }
            Console.Write(")");
            Console.WriteLine();
        }
        public void SearchingMax()
        {
            Console.WriteLine("The Max element of massiv");
            int max = int.MinValue;
            foreach (int i in array)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Maximun = " + max);
        }
        public void SearchingScalarProduct(ODArray a)
        {
            Console.WriteLine("The Dot product of two vectors/arrays");
            int product = 0;
            for(int i = 0; i < size; i++)
            {
                product += array[i] * a.array[i];
            }
            Console.WriteLine("Dot product = " + product);

        }
        public void FirstPositiveElements()
        {
            Console.WriteLine("New massif:");
            int left = 0, right = array.Length - 1;
            while(left < right)
            {
                if(array[left] < 0 && array[right] >= 0)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    right--;
                    left++;
                    continue;
                }
                if(array[left] >= 0)
                {
                    left++;
                }
                if(array[right] < 0)
                {
                    right--;
                }
            }
                
            for(int i = 0; i < size; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    class TDArray
    {
        public int size1;
        public int size2;
        public int[,] matrix;

        public TDArray(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public TDArray()
        {

        }

        public void InputElements()
        {
            Console.WriteLine("Enter the number of rows in the matrix: ");
            size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the matrix: ");
            size2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements(coordinates) of the matrix:");
            matrix = new int[size1, size2];
            Console.WriteLine("1. Random entering - 2. Yorself entering:");
            int select = Convert.ToInt32(Console.ReadLine());
            if(select == 1){
                Random ran = new Random();
                Console.WriteLine("Enter the limits of number:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < size1; i++)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        matrix[i, j] = ran.Next(n1, n2);
                    }
                }
            }
            if(select == 2)
            {
                for (int i = 0; i < size1; i++)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                    }
                }
            }
            
            Console.WriteLine();

        }
        public void OutputElements()
        {
            Console.WriteLine("Main matrix:");
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                    Console.Write("{0} ", matrix[i, j]);
                Console.Write("\n");
            }

        }
        public void SortByEvenColumn()
        {
            Console.WriteLine("New matrix");
            for(int i = 0; i< size1; i++)
            {
                for(int j = 0; j<size2; j++)
                {
                    if(i % 2 == 0)
                    {
                        for(int k = 0; k<matrix.GetLength(1) - i - 1; k++)
                        { 
                            if(matrix[k, j] > matrix[k + 1, j])
                            {
                               int t = matrix[k, j];
                               matrix[k, j] = matrix[k + 1, j];
                               matrix[k + 1, j] = t;
                            }   
                        }

                    }
                    
                }
            }
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                    
                Console.Write("\n");
            }
        }
        public void FindZeroColumn()
        {
            Console.WriteLine("The number of column with zero element:");
            int kilk = 0;
            bool zero;
            
            for(int j = 0; j < size2; j++)
            {
                zero = false;
                for(int i = 0; i < size1; i++)
                {
                    if(matrix[i, j] == 0)
                    {
                        zero = true;
                        break;
                    }
                }
                if (zero)
                {
                    kilk++;
                }
            }
            Console.WriteLine("Amount of zero column = " + kilk);
        }
        public void DeterminedLongestSeries()
        {
            Console.WriteLine("The line with the longest series of identical elements:");
            int LongestSeriesC = 0;
            int LongestSeriesR = -1;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int SeriesC = 1;
                for(int j = 1; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == matrix[i, j - 1])
                    {
                        SeriesC++;
                    } 
                    else
                    {
                        if(SeriesC > LongestSeriesC)
                        {
                            LongestSeriesC = SeriesC;
                            LongestSeriesR = i;
                        }
                        SeriesC = 1;
                    } 

                    if(SeriesC > LongestSeriesC)
                    {
                        LongestSeriesC = SeriesC;
                        LongestSeriesR = i;
                    }                
                } 
            }

            if (LongestSeriesR == -1)
            {
                Console.WriteLine("The series of similar elemnts does not exists");
            }
            else
            {
                Console.WriteLine("The number of series = " + (LongestSeriesR + 1));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work of Vadym Rybchynchuk AP-21");
            Console.WriteLine("Variant 3");

            Console.WriteLine("The OD Array:");
            Console.WriteLine("-------------------------------");
            ODArray arr = new ODArray();
            arr.InputElements();
            arr.OutputElements();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("The TD Array:");
            Console.WriteLine("-------------------------------");
            TDArray mat = new TDArray();
            mat.InputElements();
            mat.OutputElements();
            Console.WriteLine("-------------------------------");

            Console.WriteLine();
            byte select;
            do
            {
                Console.WriteLine("     ***");
                Console.WriteLine("1. Task 1.1");
                Console.WriteLine("2. Task 1.2");
                Console.WriteLine("3. Task 1.3");
                Console.WriteLine("4. Task 2.1");
                Console.WriteLine("5. Task 2.2");
                Console.WriteLine("6. Task 2.3");
                Console.WriteLine("0. To end the task");
                Console.WriteLine("     ***");
                select = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (select)
                {
                    case 1:
                        arr.SearchingMax();
                        break;
                    case 2:
                        ODArray vector = new ODArray();
                        vector.InputElements();
                        arr.SearchingScalarProduct(vector);
                        break;
                    case 3:
                        arr.FirstPositiveElements();
                        break;
                    case 4:
                        mat.SortByEvenColumn();
                        break;
                    case 5:
                        Console.WriteLine("1. This matrix - 2. New matrix: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if(n == 1)
                        {
                            mat.FindZeroColumn();
                        }
                        if(n == 2)
                        {
                            TDArray mat1 = new TDArray();
                            mat1.InputElements();
                            mat1.OutputElements();
                            mat1.FindZeroColumn();
                        }
                        break;
                    case 6:
                        mat.DeterminedLongestSeries();
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
