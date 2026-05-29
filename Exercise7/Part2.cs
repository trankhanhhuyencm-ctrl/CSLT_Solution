using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSLT_Solution.Exercise7
{
    internal class Part2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Nhập mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //8. kiểm tra số nguyên tố 
            Console.WriteLine("Các số nguyên tố trong mảng:");
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                int count = 0;

                if (arr[i] < 2)
                    continue;

                for (int j = 2; j <= Math.Sqrt(arr[i]); j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.Write(arr[i] + " ");
                    found = true;

                }

            }

            if (!found)
            {

                Console.WriteLine("EMPTY");
            }
            //9.Số chẵn số lẻ 
            Console.WriteLine();
            Console.WriteLine("Các số chẵn là: ");
            for (int i = 0; i < n; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Các số lẻ là: ");
            for (int i = 0; i < n; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }

            }
            Console.WriteLine();
            //10. Sắp xếp mảng tăng dần và giảm dần
            Console.WriteLine("Mảng được xếp theo kiểu tăng dần là: ");
            Array.Sort(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mảng được xếp theo kiểu giảm dần là: ");
            Array.Reverse(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            //11
            Console.Write("Nhập phần tử muốn chèn vào: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Mảng sau khi chèn và sắp xếp tăng dần là: ");
            ChenPhanTu(arr,a, n );
            Console.WriteLine();
            //Bài 12: Xóa một phần tử tại vị trí k
            Console.Write("Chọn vị trí index muốn xóa phần tử: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Mảng sau khi xóa phần tử: ");
            XoaPhanTu(arr, n, k);
            Console.WriteLine();
            //Bài 13: Đếm tần suất xuất hiện của các phần tử
            Console.Write("Nhập số để tìm số lần xuất hiện: ");
            int h = int.Parse(Console.ReadLine());
            int count13 = DemTanXuat(arr, h, n);
            Console.Write($"Số {h} xuất hiện {count13} lần ");
            Console.WriteLine();
            //Bài 14: Tìm phần tử xuất hiện nhiều nhất
            int kq = TimXuatHienNhieuNhat(arr, n);
            Console.WriteLine("Phan tu xuat hien nhieu nhat: " + kq);
        }
        //11: Chèn một phần tử vào mảng đã sắp xếp
        static void ChenPhanTu(int[] arr, int a, int n)
        {
            int[] arr2 = new int[n + 1];

            Array.Copy(arr, arr2, n);

            arr2[n] = a;

            Array.Sort(arr2);

            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
        //12. Xóa một phần tử tại vị trí k
        static void XoaPhanTu(int[]arr ,int n,int k)
        {
            for (int i=0;i<n; i++)
            {
                if (arr[i] ==arr[k] )
                    continue;
                Console.Write(arr[i] + " "); 
            }
        }
        //Bài 13: Đếm tần suất xuất hiện của các phần tử
        static int DemTanXuat(int[] arr, int h, int n)
        {
            int Count13 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == h)
                {
                    Count13++;
                }
            }
            return (Count13);
        }
            //Bài 14: Tìm phần tử xuất hiện nhiều nhất
            static int TimXuatHienNhieuNhat(int[] arr, int n)
            {
                int maxCount = 0;
                int result = arr[0];

                for (int i = 0; i < n; i++)
                {
                    int count = 0;

                    // Đếm số lần xuất hiện
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }

                    // Nếu xuất hiện nhiều hơn
                    if (count > maxCount)
                    {
                        maxCount = count;
                        result = arr[i];
                    }

                    // Nếu bằng nhau thì lấy số nhỏ hơn
                    else if (count == maxCount && arr[i] < result)
                    {
                        result = arr[i];
                    }
                }

                return result;
            }

        
    }
}
