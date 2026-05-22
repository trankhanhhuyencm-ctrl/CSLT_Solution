using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_Solution.Properties.Exercise6
{
    internal class Part1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 10, 12, 34, 56, 70, 25, 81, 44, 67, 4 };
            //1
            double tb = avg(arr);
            Console.WriteLine($"1. Trung bình giá trị của trong mảng: {tb}");
            //2
            Console.Write("2. Nhập vào một số để kiểm tra tồn tại: ");
            int n = int.Parse(Console.ReadLine());
            bool check = kiemtratontai(arr, n);
            if (check)
                Console.WriteLine($"{n} tồn tại trong mảng");
            else
                Console.WriteLine($"{n} không tồn tại trong mảng");
            //3.
            Console.Write("3. Nhập vào một số để kiểm tra vị trí: ");
            int k = int.Parse(Console.ReadLine());
            int vt = TimViTri(arr, k);
            if (vt != -1)
            {
                Console.WriteLine($"{k} tồn tại trong mảng tại vị trí: {vt + 1}");
            }
            else
            {
                Console.WriteLine($"{k} không tồn tại trong mảng");
            }
            //4.
            Console.Write("4. Nhập số phần tử mảng: ");
            int h = int.Parse(Console.ReadLine());
            int[] mangBai4 = new int[h];
            phatsinh_Mang(mangBai4, h);
            Console.Write("Mảng vừa được phát sinh ngẫu nhiên là: ");
            In_Mang(mangBai4, h);
            Console.Write("Nhập phần tử muốn xóa: ");
            int x = int.Parse(Console.ReadLine());
            bool kq = XoaPhanTu(mangBai4, ref h, x);
            if (!kq)
            {
                Console.WriteLine($"{x} không tồn tại trong mảng để xóa!");
            }
            else
            {
                Console.Write($"Mảng sau khi xóa phần tử {x}: ");
                In_Mang(mangBai4, h); 
            }
            Console.ReadLine();
        }

        //1.to calculate the average value of array elements.
        static double avg(int[] arr)
        {
            double a = 0, sum = 0;
            foreach (int i in arr)
                sum += i;
            a = sum / arr.Length;
            return a;
        }
        //2.to test if an array contains a specific value.
        static bool kiemtratontai(int[] arr, int n)
        {
            foreach (int i in arr)
                if (i == n)
                    return true;
            return false;
        }
        //3.to find the index of an array element.
        static int TimViTri(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                    return i;
            }
            return -1;
        }
        //4.to remove a specific element from an array.
        static bool XoaPhanTu(int[] arr, ref int h, int x)
        {
            for (int i = 0; i < h; i++)
            {
                if (arr[i] == x)
                {
                    for (int j = i; j < h - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    h--;
                    return true;
                }
            }
            return false;
        }
        static void phatsinh_Mang(int[] a, int h)
        {
            Random rand = new Random();
            for (int i = 0; i < h; i++)
            {
                a[i] = rand.Next(1, 100);
            }
        }
        static void In_Mang(int[] a, int h)
        {
            for (int i = 0; i < h; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
