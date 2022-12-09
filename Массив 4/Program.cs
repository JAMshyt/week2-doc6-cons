using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив_4
{
    class Program
    {
        static void fill(ref int[][] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("введите " + (j + 1) + " элемент " + (i + 1) + " строки:");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
        }

        static int[] newArr(int b, ref int[][] arr)
        {
            int[] arr2 = new int[b];
            for (int i = 0; i < arr.Length; i++)
            {
                int num = 111;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i][j]) % 2 == 0 | arr[i][j] == 0)
                    {
                        num = arr[i][j];
                    }
                }

                arr2[i] = num;
            }
            return arr2;
        }

        static void Main(string[] args)
        {
            int a;
            try
            {
                Console.Write("Введите n: ");
                a = Convert.ToInt32(Console.ReadLine());
                int[][] arr = new int[a][];
                for (int i = 0; i < a; i++)
                {

                    arr[i] = new int[a];
                }
                fill(ref arr);
                Console.WriteLine("Последние четные элементы строк");
                int co = 1;
                foreach (int e in newArr(a, ref arr))
                {

                    if (e == 111)
                    {
                        Console.Write("нету ");
                        co++;
                    }
                    else
                    {
                        Console.Write(e+" ");
                        co++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
