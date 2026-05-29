using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_Solution.Exercise7
{
    internal class Part1
    {
        static int[,] NhapMang_Manual(int rows, int columns )
        {
            int[,] a = new int[rows, columns];
            for ( int i = 0;i < rows; i++ )
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return a; 
        }
       static int[,] NhapMang_NgauNhien(int rows, int columns)
        {
            int[,] a = new int[rows,columns];
            Random rd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    a[i,j] = rd.Next(100);
                }
            }
            return a;

        }
        static void InMang(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++) 
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        /*static void PrintRow(int[,]a, int rowIndex)
        {

        }*/
        static int Max(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
                return max;
        }
        public static void Main(String[] args)
        {
            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = NhapMang_NgauNhien(n,m);
            Console.WriteLine("\nMang sau khi nhap: ");
            InMang(a);
            /*Console.Write("Nhap dong can in: ");
            int rowIndex= int .Parse(Console.ReadLine());
            PrintRow(a, rowIndex);*/
            int ma = Max(a); 
            Console.Write($"Gia tri lon nhat la: {ma}");


        }


    }
}
