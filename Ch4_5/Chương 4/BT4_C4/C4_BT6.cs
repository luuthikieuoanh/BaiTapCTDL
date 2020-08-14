using C4_BT5;
using System;
using System.Reflection;

namespace C4_BT6
{
    class C4_BT6
    {


        static void Main(string[] args)
        {
            LinkedList F1 = new LinkedList();
            LinkedList F2 = new LinkedList();

            //NẾU MUỐN THAY ĐỔI BẬC ĐA THỨC, VUI LÒNG THAY ĐỔI GIÁ TRỊ TRONG DẤU NGOẶC
            //Ở CHƯỜNG TRÌNH NÀY, USER PHẢI NHẬP THEO CHIỀU GIẢM DẦN SỐ MŨ
            //Câu A : Nhập đa thức
            //F1 LA ĐA THỨC BẬC 2
            F1.NhapDaThuc(2);

            //F2 LÀ ĐA THỨC BẬC 3
            F2.NhapDaThuc(3);

            //Câu B : Xuất đa thức
            Console.Write("Da thuc F1: ");
            F1.Print();

            Console.Write("\nDa thuc F2: ");
            F2.Print();

            //Câu C : Tính Đạo hàm
            //F1.TinhDaoHam();
            //Console.Write("\nDao Ham Da thuc F1: ");
            //F1.Print();

            //F2.TinhDaoHam();
            //Console.Write("\nDao Ham Da thuc F2: ");
            //F2.Print();

            //Câu D : Tính giá trị đa thức với X nhập từ bàn phím
            //Console.Write("Nhap gia tri X = ");
            //int.TryParse(Console.ReadLine(), out int iX);
            //Console.WriteLine("\nGia tri da thuc F1 khi X = {0} : {1}",iX, CauD(F1, iX));


            //Cau E :TÍNH TỔNG ĐA THỨC F1 VÀ F2
            //LinkedList F3 = TongDaThuc(F1, F2);
            //Console.Write("\nTong F1 + F2: ");
            //F3.Print();

            //CÂU F :  TÍNH TÍCH ĐA THỨC F1 VÀ F2
            LinkedList F4 = TichDaThuc(F1, F2);
            Console.Write("\nTich F1 * F2: ");
            F4.Print();

            Console.ReadKey();
        }
        //TÍNH TÍCH ĐA THỨC F1 VÀ F2
        static LinkedList TichDaThuc(LinkedList F1, LinkedList F2)
        {
         
            LinkedList KQ = new LinkedList();

            for (Node p = F1.First; p != null; p = p.Next)
            {
                LinkedList F3 = new LinkedList();
                for (Node q = F2.First; q != null; q = q.Next)
                {                 
                    F3.AddLast(new PhanTuDaThuc(p.Data.heso * q.Data.heso, p.Data.somu + q.Data.somu));
                }
                KQ = TongDaThuc(KQ, F3);
            }

            return KQ;
        }

        //TÍNH TỔNG F1 VÀ F2
        static LinkedList TongDaThuc(LinkedList F1, LinkedList F2)
        {
            LinkedList F3 = new LinkedList();

            //DUYỆT 2 MẢNG TỪ ĐẦU ĐẾN CUỐI
            //NẾU TOÁN HẠNG CÙNG HỆ SỐ THÌ CỘNG HỆ SỐ LẠI, THÊM VÀO CUỐI L3
            //NẾU TOÁN HẠNG K CÙNG HỆ SỐ, THÊM TOÁN HẠNG CÓ HỆ SỐ LỚN HƠN VÀO L3
            Node p = F1.First;
            Node q = F2.First;

            while (p != null && q != null)
            {
                if (p.Data.somu == q.Data.somu)
                {
                    F3.AddLast(new PhanTuDaThuc(p.Data.heso + q.Data.heso, p.Data.somu));
                    p = p.Next;
                    q = q.Next;
                }
                else if (p.Data.somu > q.Data.somu)
                {
                    F3.AddLast(p.Data);
                    p = p.Next;
                }
                else if (p.Data.somu < q.Data.somu)
                {
                    F3.AddLast(q.Data);
                    q = q.Next;
                }
            }

            //KHI F1 KẾT THÚC TRƯỚC, THÊM CÁC PHẦN TỬ CÒN LẠI CỦA F2 VÀO L3
            while (p == null && q != null)
            {
                F3.AddLast(q.Data);
                q = q.Next;
            }

            //KHI F2 KẾT THÚC TRƯỚC, THÊM CÁC PHẦN TỬ CÒN LẠI CỦA F1 VÀO L3
            while (q == null && p != null)
            {
                F3.AddLast(p.Data);
                p = p.Next;
            }

            return F3;
        }

        //Tính giá trị đa thức vs X cho trước
        static double CauD(LinkedList F1, int iX)
        {
            double result = 0;
            for (Node p = F1.First; p != null; p = p.Next)
            {
                result += p.Data.heso * Math.Pow(iX, p.Data.somu);
            }
            return result;
        }
    }
}
