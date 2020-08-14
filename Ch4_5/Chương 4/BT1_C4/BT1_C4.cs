using System;

namespace BT1_C4
{
    class BT1_C4
    {

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int iN = 0;
            Console.WriteLine("Nhap so phan tu cua mang");
            int.TryParse(Console.ReadLine(), out iN);

            list = TaoList(list, iN);
            list.PrintList();

            ////Liệt kê các số nguyên tố ra màn hình
            //LietKeSNT(list);

            ////Tính trung bình cộng 
            //double dTBC = TBC(list);
            //Console.WriteLine("Trung binh cong cua day = {0}", dTBC);

            ////Đếm số lần xuất hiện cua 1 số nguyên nhập từ bàn phím
            //Console.WriteLine("Nhap so nguyen ban muon tim");
            //int.TryParse(Console.ReadLine(), out int iTim);
            //Console.WriteLine("So lan xuat hien cua phan tu co gia tri {0} = {1}", iTim, SoLanXuatHien(list, iTim));

            ////Tìm số chính phương cuối cùng trong danh sách
            //Console.WriteLine("So chinh phuong cuoi cung trong danh sach = {0}", SCPCuoiCung(list));

            //Tìm phần tử Min
            Console.WriteLine("Phan tu co gia tri nho nhat = {0}", TimMin(list));

            Console.ReadKey();
        }
        //Tìm phần tử Min
        static int TimMin(LinkedList list)
        {
            int KQ = list.First.Data;
            Node p = list.First;
            while (p != null)
            {
                if (KQ > p.Data)
                {
                    KQ = p.Data;
                }
                p = p.Next;
            }
            return KQ;
        }

        //Kiểm tra SCP
        static bool KTSCP(int Data)
        {
            for (int i = 2; i <= Data / 2; i++)
            {
                if (Data == i * i)
                {
                    return true;
                }
            }
            return false;
        }
        //Tìm số chính phương cuối cùng trong danh sách
        static int SCPCuoiCung(LinkedList list)
        {
            int KQ = -1;
            for (Node p = list.First; p != null; p = p.Next)
            {
                if (KTSCP(p.Data))
                {
                    KQ = p.Data;
                }
            }
            return KQ;
        }

        //Đếm số lần xuất hiện cua 1 số nguyên nhập từ bàn phím
        static int SoLanXuatHien(LinkedList list, int Tim)
        {
            int Dem = 0;

            for (Node p = list.First; p != null; p = p.Next)
            {
                if (p.Data == Tim)
                {
                    Dem++;
                }
            }
            return Dem;
        }

        //Tính trung bình cộng 
        static double TBC(LinkedList list)
        {
            double S = 0;
            Node p = list.First;
            while (p != null)
            {
                S += p.Data;
                p = p.Next;
            }
            return S / list.Count;
        }

        //Kiểm tra SNT
        static bool KTSNT(int data)
        {
            if (data < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= data / 2; i++)
                {
                    if (data % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Liệt kê các số nguyên tố ra màn hình
        static void LietKeSNT(LinkedList list)
        {
            Console.WriteLine("Cac so nguyen to co trong list :");
            for (Node p = list.First; p != null; p = p.Next)
            {
                if (KTSNT(p.Data))
                {
                    Console.Write("{0}\t", p.Data);
                }
            }
            Console.WriteLine();
        }

        //Nhập mảng tự động
        static LinkedList TaoList(LinkedList list, int iN)
        {
            Random NN = new Random();

            for (int i = 0; i < iN; i++)
            {
                list.AddLast(NN.Next(0, 11));
            }

            return list;
        }
    }
}

