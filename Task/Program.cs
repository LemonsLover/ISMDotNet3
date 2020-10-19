using System;

namespace Task
{
    class Program
    {
        static public double SumNegative(double[] arr)
        {
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    sum += arr[i];
            }
            return sum;
        }
        static public double MaxElement(double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static public int MaxElementIndex(double[] arr)
        {
            double max = arr[0];
            int i_max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    i_max = i;
                }
            }
            return i_max;
        }
        static public double MaxElementByModule(double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                    max = arr[i];
            }
            return max;
        }
        static public int MaxElementByModuleIndex(double[] arr)
        {
            double max = arr[0];
            int i_max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                {
                    max = arr[i];
                    i_max = i;
                }
            }
            return i_max;
        }

        static public double SumOfPositiveNumbers(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += i;
            }
            return sum;
        }
        static public int AmountOfIntegerNumbers(double[] arr)
        {
            int colvo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 1 == 0)
                    colvo ++;
            }
            return colvo;
        }
        static public void ArraySort(double[] arr)
        {
            double temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static public int AmountOfPositiveNumbers(double[] arr)
        {
            int colvo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    colvo++;
            }
            return colvo;
        }
        static public double[] DeleteNagativeNumbers(double[] arr)
        {
            double[] newArr = new double[AmountOfPositiveNumbers(arr)];
            int j = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter amount of numbers in array:"); int amount = int.Parse(Console.ReadLine());
            double[] arr = new double[amount];
            Console.WriteLine($"Fill array with {amount} numbers:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"index {i} = ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum of negative numbers: {SumNegative(arr)}");
            Console.WriteLine($"Max element in array: {MaxElement(arr)}, and it's index is: {MaxElementIndex(arr)}");
            Console.WriteLine($"Max number by module: {MaxElementByModule(arr)}, and it's index is: {MaxElementByModuleIndex(arr)}");
            Console.WriteLine($"Sum of positive indexes: {SumOfPositiveNumbers(arr)}");
            Console.WriteLine($"Amount of integer numbers: {AmountOfIntegerNumbers(arr)}");
            Console.WriteLine("Sorted array:");
            ArraySort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"index {i} = " +arr[i] + "\n");
            Console.WriteLine("Array with deleted negative numbers:");
            arr = DeleteNagativeNumbers(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"index {i} = " + arr[i] + "\n");

        }
    }
}
