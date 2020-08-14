
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BT6_C5
{
    class BT6_C5
    {

        static void Main(string[] args)
        {
            //Khởi tạo danh sách số ghế trống A
            LinkedList<int> A = new LinkedList<int>();
            A = SetSoGheTrong(A);
            XuatLLA(A);

            //Khởi tạo danh sách thông tin khách mua vé C
            LinkedList<KhachHang> C = new LinkedList<KhachHang>();
            //XuatLLC(C);

            //Khởi tạo hàng đợi B chứa số thứ tự xếp hàng của khách
            ListQueue B = new ListQueue();

            //Menu
            int ichon = 0;
            do
            {
                Console.Clear();
                Menu();
                Console.Write("Ban hay chon chuc nang : ");
                int.TryParse(Console.ReadLine(), out ichon);
                switch (ichon)
                {
                    case 1:
                        //Chức năng lấy số xếp hàng
                        LaySoXH(B);
                        break;
                    case 2:
                       
                        //Chức năng mua vé
                        MuaVe(A, B, C);
                        XuatLLC(C);
                        break;
                    case 3:
                        //Chức năng hủy vé
                        HuyVe(A, C);
                        break;
                    case 4:
                        //Hiển thị danh sách vé đã bán
                        XuatLLC(C);
                        break;
                    default:
                        break;

                }
            } while (ichon > 0 && ichon <= 4);

            Console.ReadKey();
        }
        //Menu
        static void Menu()
        {
            Console.WriteLine("-----------------MENU------------------");
            Console.WriteLine("\t 1. Lay so xep hang.");
            Console.WriteLine("\t 2. Mua ve.");
            Console.WriteLine("\t 3. Huy ve.");
            Console.WriteLine("\t 4. Xuat danh sach ve.");
            Console.WriteLine("\t Chon phim khac de thoat.");
            Console.WriteLine("---------------------------------------");
        }
        //Tìm Node Khách Hàng trong list C
        static LinkedListNode<KhachHang> TimKH(LinkedList<KhachHang> C, string tenkh)
        {
            for (LinkedListNode<KhachHang> p = C.First; p != null; p = p.Next)
            {
                if (p.Value.TenKH == tenkh)
                {
                    return p;
                }
            }
            return null;
        }

        //Chức năng hủy vé
        static void HuyVe(LinkedList<int> A, LinkedList<KhachHang> C)
        {
            string tenkh = "";

            if (C.First == null)
            {
                Console.WriteLine("Danh sach khach hang mua ve rong!");
            }
            else
            {
                //Nhập tên KH muốn hủy vé, nếu tên không tồn tại thì kết thúc chức năng
                Console.WriteLine("Nhap ten Khach Hang muon huy ve");
                tenkh = Console.ReadLine();

                LinkedListNode<KhachHang> p = TimKH(C, tenkh);

                if (p == null)
                {
                    Console.WriteLine("Khach hang ten {0} khong ton tai trong he thong", tenkh);
                }
                else
                {
                    //Xóa khách hàng khỏi C
                    C.Remove(p);

                    //Thêm số ghế vào A
                    A.AddLast(p.Value.SoGhe);

                    Console.WriteLine("Huy ve khach hang {0} thanh cong!", tenkh);
                }
            }
        }

        //Chức năng mua vé
        static void MuaVe(LinkedList<int> A, ListQueue B, LinkedList<KhachHang> C)
        {
            if (A.First == null)
            {
                Console.WriteLine("Rap da het cho!");
                Console.ReadKey();
            }
            else
            {
                if (B.Front == null)
                {
                    Console.WriteLine("Hang cho Rong!");
                    Console.ReadKey();
                }
                else
                {
                    XuatLLA(A);
                 
                    Console.Write("Nhap ten KH : ");
                    string tenKH = Console.ReadLine();

                    int soghe = -1;
                    do
                    {
                        Console.Write("Nhap so ghe : ");
                        int.TryParse(Console.ReadLine(), out soghe);
                    } while (A.Find(soghe) == null);

                    //Xóa nút B
                    B.DeQueue();

                    //Thêm nút vào C
                    C.AddLast(new KhachHang(soghe, tenKH));
                    Console.WriteLine("Khach hang {0} dat cho thanh cong!", tenKH);
                }
            }
        }

        //Chức năng lấy số xếp hàng
        static void LaySoXH(ListQueue B)
        {
            if (B.Front == null)
            {
                B.EnQueue(1);
            }
            else
            {
                //Thêm 1 Khách Hàng mua vé
                int tam = B.Rear.Data;

                B.EnQueue(tam + 1);
            }
            XuatB(B);
            Console.ReadKey();
        }

        //Xuất danh sách LinkedList C ra màn hình
        static void XuatLLC(LinkedList<KhachHang> C)
        {
            Console.WriteLine("---DANH SACH KHACH HANG MUA VE----");
            for (LinkedListNode<KhachHang> p = C.First; p != null; p = p.Next)
            {
                Console.Write("KH : {0,-25} So ghe: {1}", p.Value.TenKH, p.Value.SoGhe);
            }
            Console.WriteLine();
            Console.WriteLine("Co {0} khach hang mua ve", C.Count);
        }

        //Xuất queue B
        static void XuatB(ListQueue B)
        {
            Console.WriteLine("Hang Cho :");
            for (Node p = B.Front; p != null; p = p.Next)
            {
                Console.Write("{0,-10}", p.Data);
            }
            Console.WriteLine();
        }

        //Xuất danh sách LinkedList A ra màn hình
        static void XuatLLA(LinkedList<int> A)
        {
            Console.WriteLine("Danh Sach Ghe Trong:");
            for (LinkedListNode<int> p = A.First; p != null; p = p.Next)
            {
                Console.Write("{0,-10}", p.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Rap chieu phim con {0} ghe trong", A.Count);
        }

        //Tạo danh sách chứa số ghế trống trong rạp
        static LinkedList<int> SetSoGheTrong(LinkedList<int> A)
        {
            Console.WriteLine("Nhap so luong ghe trong");
            int.TryParse(Console.ReadLine(), out int ghetrong);

            for (int i = 1; i <= ghetrong; i++)
            {
                A.AddLast(i);
            }

            return A;

        }
    }
}
