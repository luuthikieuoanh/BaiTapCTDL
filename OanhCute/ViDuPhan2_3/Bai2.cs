using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTThucHanh2_3
{
    class Bai2
    {
        static void Main(String[] args)
        {
            //Nhap mang
            int[] arr = TaoMang();
            //In mang
            Console.WriteLine("Mang truoc khi xoa la: ");
            foreach (var k in arr)
            {
                Console.Write(k + "  ");
            }
            //Nhap phan tu cam xoa
            Console.WriteLine();
            int del = 0;
            Console.Write("Nhap phan tu can xoa: ");
            int.TryParse(Console.ReadLine(), out del);
            //In mang sau khi xoa
            Console.WriteLine("Mang sau khi xoa phan tu {0} la: ", del);
            int[] newArr = MangSauKhiXoa(arr, del);
            foreach (var ele in newArr)
            {
                Console.Write(ele + "  ");
            }

            Console.ReadKey();
        }

        //Ham tao mang
        static int[] TaoMang()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap n phan tu: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 0);
            //Tao mang ngau nhien voi n phan tu
            int[] arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(n);
            }
            return arr;
        }

        //Ham lay mang sau khi xoa phan tu
        static int[] MangSauKhiXoa(int[] arr, int del)
        {
            int[] newArr = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != del)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);//Thay doi do dai moi cho mang
                    newArr[newArr.Length - 1] = arr[i];//Tao gia tri cho mang moi
                }
            }
            return newArr;
        }
    }
}
