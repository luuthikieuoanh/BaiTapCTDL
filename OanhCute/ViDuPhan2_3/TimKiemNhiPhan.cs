/*BT BinarySearch: Thuat toan tim kiem nhi phan
 * Date: 29/5/2020
 * Name: Luu Thi Kieu Oanh
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTThucHanh2_3
{
    class TimKiemNhiPhan
    {
        static void Main(string[] args)
        {
            //Tạo mảng
            int[] mang = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Nhập key
            int key = 0;
            Console.Write("Nhap key can tim: ");
            int.TryParse(Console.ReadLine(), out key);

            //Tìm vị trí và in ra màn hình
            //In so lan chia doi
            //In khoang
            int viTri = BinarySearch(mang, key);
            if (viTri == -1)
            {
                Console.WriteLine("Khong tim thay vi tri cua {0}", key);
            }
            else
            {
                Console.WriteLine("Vi tri {0} la {1}", key, viTri);
                int dem = 0;
                dem = TinhSoLanChiaDoi(mang, key);
                Console.WriteLine("So lan chia doi trong mang la: {0}", dem);
                InKhoang(mang, key);
            }

            Console.ReadKey();
        }

        //Hàm tìm vị trí của key
        static int BinarySearch(int[] arr, int key)
        {
            int viTri = -1;
            int left = 0;
            int right = arr.Length - 1;
            int mid = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                mid = (left + right) / 2;
                if (arr[mid] == key)
                {
                    viTri = mid;
                    break;
                }
                else if (arr[mid] > key)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                }

            }
            return viTri;
        }

        static void InKhoang(int[]arr,int key)
        {
            
            int left = 0;
            int right = arr.Length - 1;
            int mid = 0;
            
            for (int i = 1; i <= arr.Length; i++)
            {
                mid = (left + right) / 2;
                
                Console.WriteLine("Lan {0}: x={1} nam trong doan [{2}..{3}]//mid={4}", i, key, left, right, mid);
                if (arr[mid] == key)
                {                   
                    break;
                }
                else if (arr[mid] > key)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                }

            }
        }

        static int TinhSoLanChiaDoi(int[] arr, int key)
        {
            int dem = 0;
            int left = 0;
            int right = arr.Length - 1;
            int mid = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                mid = (left + right) / 2;
                dem++;
                if (arr[mid] == key)
                {
                    break;
                }
                else if (arr[mid] > key)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return dem;
        }
    }
}
