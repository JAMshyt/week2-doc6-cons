using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив_3
{
    class Program
    {

        static void fill(int n, ref double[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите " + (j+1) + " элемент "+(i+1)+" строки: ");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void powM(int n, int b, ref double[,] arr)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(arr[i,j] >= 0) arr[i, j] = Math.Pow(arr[i,j],b);
                    else if(b %2 ==0) arr[i, j] = Math.Abs(Math.Pow(arr[i, j],b));
                    else arr[i, j] = Math.Pow(arr[i, j], b);
                    Console.Write(Math.Round(arr[i, j]) + " ");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            do
            {
                int a = 0;
                try
                {
                    do
                    {
                        Console.WriteLine("Введитеn n:");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a > 0) break;
                        else Console.WriteLine("n должно быть больше 0");
                    } while (true);
                    Console.WriteLine("Введите степень: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a < 1) Console.WriteLine("Кол-во ячеек не должно быть меньше 1");
                    else
                    {
                        double[,] arr = new double[a, a];
                        fill(a, ref arr);
                        Console.WriteLine("Перемножееный массив: ");
                        powM(a, b, ref arr);
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
            } while (true);
        }
    }
}
