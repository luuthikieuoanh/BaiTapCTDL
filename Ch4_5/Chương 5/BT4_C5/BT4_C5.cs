using System;
using System.IO;
using System.Reflection;

namespace BT4_C5
{
    class BT4_C5
    {
 

        static void Main(string[] args)
        {
            ListQueue queue = new ListQueue();

            //CÂU B: Add dữ liệu
            queue = Input();

            //CÂU C: XEM DANH SÁCH HÀNG HÓA 
            XuatTT(queue);

            //CÂU D: XEM MẶT HÀNG SẮP ĐƯỢC XUẤT KHO
            //Console.Clear();
            //Console.WriteLine("MAT HANG SAP DUOC XUAT KHO :");
            //queue.Peek().Display();

            //CÂU E: THÊM MỘT MẶT HÀNG VÀO KHO
            //CauE(queue);
            //XuatTT(queue);


            //CÂU F: XUẤT MỘT MẶT HÀNG RA KHỎI KHO
            Console.WriteLine("-----MAT HANG VUA DUOC XUAT KHO-----");
            queue.DeQueue().Display();

            Console.ReadKey();
        }
        //CÂU E: THÊM MỘT MẶT HÀNG VÀO KHO
        static void CauE(ListQueue q)
        {
            Console.WriteLine("--------THEM MAT HANG VAO KHO-------");
            Console.Write("Nhap Ten mat hang : ");
            string ten = Console.ReadLine();

            Console.Write("Nhap so luong : ");
            int.TryParse(Console.ReadLine(), out int soluong);

            Console.Write("Nhap don gia : ");
            int.TryParse(Console.ReadLine(), out int dongia);

            q.EnQueue(new HangHoa(ten, soluong, dongia));
        }

        //Xuất danh sách ra màn hình
        static void XuatTT(ListQueue q)
        {
            for (Node p = q.Front; p != null; p = p.Next)
            {
                p.Data.Display();
            }
        }

        //Input
        static ListQueue Input()
        {
            ListQueue q = new ListQueue();
            using (StreamReader sR = new StreamReader("C:\\Users\\HUNG\\Desktop\\C#\\CTDL_Cô Trinh\\Chương 5\\BT4_C5\\Input.txt"))
            {
                while (sR.Peek() > 0)
                {
                    string[] sLine = sR.ReadLine().Split('#', StringSplitOptions.RemoveEmptyEntries);
                    int.TryParse(sLine[1], out int soluong);
                    int.TryParse(sLine[2], out int dongia);

                    q.EnQueue(new HangHoa(sLine[0], soluong , dongia));
                }
            }

            return q;
        }
    }
}
