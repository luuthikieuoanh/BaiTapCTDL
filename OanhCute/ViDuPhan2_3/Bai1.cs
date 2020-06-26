using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTThucHanh2_3
{
    class Bai1
    {
        static void Main(String[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 1 };

            //Nhap key can tim
            int key = 0;
            Console.Write("Nhap key can tim: ");
            int.TryParse(Console.ReadLine(), out key);

            //Tim vi tri key trong mang
            //CACH 1
            //Console.Write("Cac vi tri cua {0} trong mang la: ", key);
            //bool flag = true;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == key)
            //    {
            //        Console.Write(i + "  ");
            //        flag = false;
            //    }
            //}
            //if (flag)
            //{
            //    Console.WriteLine("Khong tim thay ");
            //}

            //CACH 2
            int[] viTri = LinearSearch(arr, key);
            Console.Write("Cac vi tri cua {0} trong mang la: ", key);
            for (int i = 0; i < viTri.Length; i++)
            {
                Console.Write(viTri[i] + "  ");
            }

            Console.ReadKey();
        }

      static int[] LinearSearch(int[]arr,int key)
        {
            int[] viTri = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==key)
                {
                    Array.Resize(ref viTri, viTri.Length + 1);
                    viTri[viTri.Length - 1] = i;
                    
                }
            }
            return viTri;
        }
    }



}
