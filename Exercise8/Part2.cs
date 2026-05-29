using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_Solution.Exercise8
{
    internal class Part2
    {
        /*
    1.Nhập một chuỗi và in nó ra.
    2.Tìm độ dài của chuỗi mà không dùng hàm thư viện.
    3.Tách từng ký tự riêng lẻ từ chuỗi.
    4.In các ký tự của chuỗi theo thứ tự ngược lại.
    5.Đếm tổng số từ trong chuỗi.
    6.So sánh hai chuỗi mà không dùng hàm thư viện xử lý chuỗi.
    7.Đếm số chữ cái, chữ số và ký tự đặc biệt trong chuỗi.
    8.Đếm số nguyên âm và phụ âm trong chuỗi.
    9.Kiểm tra xem một chuỗi con có xuất hiện trong chuỗi hay không.
    10.Tìm vị trí của chuỗi con trong chuỗi.
    11.Kiểm tra một ký tự có phải chữ cái hay không; nếu đúng thì kiểm tra chữ hoa hay chữ thường.
    12.Tìm số lần xuất hiện của một chuỗi con trong chuỗi.
    13.Chèn một chuỗi con trước lần xuất hiện đầu tiên của một chuỗi khác.*/
        public static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.nhập một chuỗi và in nó ra.
            Console.WriteLine("Nhập một chuỗi: ");
            string str = Console.ReadLine();
            //2.tìm độ dài của chuỗi mà không dùng hàm thư viện (strlen, .Length, …).
            int result2 = StringLength(str);
            Console.WriteLine("Độ dài của chuỗi là: " + result2);
            //3.Tách từng ký tự riêng lẻ từ chuỗi.
            Console.WriteLine("Tách từng ký tự riêng lẻ của chuỗi: ");
            TachKyTu(str);
            //4.In các ký tự của chuỗi theo thứ tự ngược lại.
            Console.WriteLine("In các ký tự của chuỗi theo thứ tự ngược lại: ");
            InNguoc(str);
            //5.Đếm tổng số từ trong chuỗi.
            int tong = TongTu(str);
            Console.WriteLine("Tổng các từ trong chuỗi là: " + tong);
            //6.So sánh hai chuỗi mà không dùng hàm thư viện xử lý chuỗi.
            Console.WriteLine("Nhập thêm chuỗi thứ 2: ");
            string str2 = Console.ReadLine();
            bool result6 = SoSanh(str, str2);
            if (result6)
                Console.WriteLine("Hai chuỗi giống nhau");
            else
                Console.WriteLine("Hai chuỗi khác nhau");
            //7.Đếm số chữ cái, chữ số và ký tự đặc biệt trong chuỗi.
            Console.WriteLine($"Chuỗi \'{str}\' có: ");
            Dem(str);
            //8.Đếm số nguyên âm và phụ âm trong chuỗi.
            DemDem(str);
            //9.Kiểm tra xem một chuỗi con có xuất hiện trong chuỗi hay không.
            Console.Write("Nhap chuỗi con: ");
            string sub = Console.ReadLine();

            bool result9 = CheckSubstring(str, sub);

            if (result9)
            {
                Console.WriteLine("Chuỗi con có tồn tại");
            }
            else
            {
                Console.WriteLine("Chuỗi con không tồn tại");
            }
            //12.Tìm số lần xuất hiện của một chuỗi con trong chuỗi.
            int Solan = XuatHien (str, sub);
            Console.WriteLine("Số lần xuất hiên chuỗi con:" +Solan);

        }


        //2.tìm độ dài của chuỗi mà không dùng hàm thư viện(strlen, .Length, …).
        static int StringLength(string str)
        {
            int length = 0;

            foreach (char c in str)
            {
                length++;
            }

            return length;
        }
        //3.Tách từng ký tự riêng lẻ từ chuỗi.
        static void TachKyTu(string str)
        {
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
        }
        //4.In các ký tự của chuỗi theo thứ tự ngược lại.
        static void InNguoc(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }

        }
        //5.Đếm tổng số từ trong chuỗi.
        static int TongTu(string str)
        {
            string[] words = str.Split(' ');
            return words.Length;
        }
        //6.So sánh hai chuỗi mà không dùng hàm thư viện xử lý chuỗi.
        static bool SoSanh(string str, string str2)
        {
            if (str.Length != str2.Length)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str2[i])
                    return false;
            }
            return true;
        }
        //7.Đếm số chữ cái, chữ số và ký tự đặc biệt trong chuỗi.
        static void Dem(string str)
        {
            int chu = 0;
            int so = 0;
            int kytu = 0;
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                    chu++;
                else if (Char.IsDigit(c))
                    so++;
                else if (c == ' ')
                    continue;
                else
                    kytu++;
            }
            Console.WriteLine($"{chu} chữ cái ");
            Console.WriteLine($"{so} chữ số ");
            Console.WriteLine($"{kytu} ký tự đặc biệt ");
        }
        //8.Đếm số nguyên âm và phụ âm trong chuỗi.
        static void DemDem(string str)
        {
            int nguyenam = 0;
            int phuam = 0;
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    if ("euoaiEUOAI".Contains(c))
                        phuam++;
                    else
                        nguyenam++;
                }

            }
            Console.WriteLine($"{phuam} phụ âm ");
            Console.WriteLine($"{nguyenam} nguyên âm ");
        }
            //9.Kiểm tra xem một chuỗi con có xuất hiện trong chuỗi hay không.
            static bool CheckSubstring(string str, string sub)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    int j;

                    // So sánh từng ký tự
                    for (j = 0; j < sub.Length; j++)
                    {
                        if (str[i + j] != sub[j])
                        {
                            break;
                        }
                    }

                    // Nếu j chạy hết sub.Length nghĩa là tìm thấy
                    if (j == sub.Length)
                    {
                        return true;
                    }
                }

                return false;
            }

        //12.Tìm số lần xuất hiện của một chuỗi con trong chuỗi.
        static int XuatHien(string str,string sub)
        {
            int count12 = 0;
            int index = 0;

            while ((index = str.IndexOf(sub, index)) != -1)
            {
                count12++;

                // Nhảy qua chuỗi vừa tìm được
                index = index + sub.Length;
            }
            return count12;
        }
    }

}

