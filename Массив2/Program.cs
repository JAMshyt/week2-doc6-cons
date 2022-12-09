using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив2
{
    class Program
    {
        static void fill(int n, ref double[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i+1) + " элемент: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        static double minL(double[] arr)
        {
            int lastMin = 0;
            double min = 16;
            for( int i = 0; i < arr.Length; i++)
            {
                if (Math.Min(arr[i], min) == arr[i])
                {
                    min = arr[i];
                    lastMin = i + 1;
                }
            }
            return lastMin;
        }
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Введите кол-во ячеек в массиве: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a < 1) Console.WriteLine("Кол-во ячеек не может быть отрицательным");
                    else
                    {
                        double[] arr = new double[a];
                        fill(a,ref arr);
                        Console.WriteLine("Номер последнего минимального элемента: "+minL(arr));
                    }
                }
                catch
                {
                    Console.WriteLine("Кол-во ячеек должно быть целым неотрицательным числом");
                }
            } while (true);
        }
    }
}
