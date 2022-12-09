using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив1
{
    class Program
    {

        static void fill(int n, ref int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + i + " элемент: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void fill(int n,int m, ref int[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Введите " + (j+1) + " элемент " + (i+1) + " строки: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
        }

        static void show(int n, int[] arr)
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < n; i++) Console.Write(" " + arr[i] + " ");
            Console.WriteLine("\n");
        }
        static void show(int n, int m, int[,] arr)
        {
            Console.WriteLine("Двумерный массив:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        static void coutN(int[] arr)
        {
            try
            {
                Console.Write("Введите начало диапазона: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите конец диапазона: ");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A >= B) Console.WriteLine("Начало диапазона должно быть меньше конца");
                else
                {
                    int cout = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i >= A - 1 & i <= B - 1) continue;
                        else cout++;
                    }
                    Console.WriteLine("Кол-во элементов не входящих в диапазон: " + cout);
                }
            }
            catch { Console.WriteLine("Ошибка"); }
        }
        static void coutN(int[,] arr, int n,int m)
        {
            try
            {
                Console.Write("Введите начало диапазона: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите конец диапазона: ");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A >= B) Console.WriteLine("Начало диапазона должно быть меньше конца");
                else
                {
                    int C = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (arr[i,j] >=A & arr[i, j] <= B)
                            {
                                continue;
                            }
                            else
                            {
                                C++;
                            }
                        }
                    }
                    Console.WriteLine("Кол-во элементов не входящих в диапазон чисел: " + C);
                }
            }
            catch { Console.WriteLine("Ошибка"); }
        }

        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                try
                {
                    Console.WriteLine("введите тип массива");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
                if (a != 1 & a != 2) Console.WriteLine("Тип массива должен быть равен 1 или 2");
                else break;
            } while (true);
            if (a == 1)
            {
                try
                {
                    Console.WriteLine("Кол-во столбцов: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];
                    fill(n, ref arr);
                    show(n, arr);
                    coutN(arr);
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }

            }
            else
            {
                try
                {
                    Console.WriteLine("Кол-во строк: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Кол-во столбцов: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    int[,] arr = new int[n, m];
                    fill(n, m, ref arr);
                    show(n, m, arr);
                    coutN(arr, n, m);
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }

    }
}

