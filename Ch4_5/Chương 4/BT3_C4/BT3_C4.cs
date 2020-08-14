using System;

namespace BT3_C4
{
    class BT3_C4
    {
    
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //Câu A : Nhập dữ liệu = hàm
            //list = list.NhapDLlist();

            //Nhập dữ liệu bằng cách truyền tham số vào Constructors
            list.AddLast(new SinhVien("Nguyen Bao Binh", "TT1", new DateTime(1999, 2, 11), 7.5));
            list.AddLast(new SinhVien("Hoang Thai An", "TT4", new DateTime(2000, 8, 15), 8.71));
            list.AddLast(new SinhVien("Truong Bao Yen", "TT9", new DateTime(1995, 4, 21), 4.52));
            list.AddLast(new SinhVien("Pham The Huy", "TT3", new DateTime(2001, 12, 1), 6.75));
            list.AddLast(new SinhVien("Huynh Tuan Kiet", "TT8", new DateTime(1998, 2, 19), 9.19));
            list.AddLast(new SinhVien("Duong Thai Chau", "TT82", new DateTime(2001, 5, 19), 4.96));
            list.AddLast(new SinhVien("Nguyen Hoang Nguyet Anh", "TT5", new DateTime(1998, 8, 15), 5));
            Console.WriteLine("Danh sach co {0} sinh vien",list.Count);
            list.PrintList();


            ////Câu B : Xuất danh sách ra màn hình
            //list.PrintList();

            ////Câu C : In ra danh sách các sinh viên có điểm trung bình lớn hơn hoặc bằng 5.
            //CauC(list);

            //Câu D: Tìm tuần tự thông tin của một sinh viên theo mã sinh viên.
            //Console.Write("Nhap ma SV ban muon tim : ");
            //string sTimSV = Console.ReadLine();
            //Console.WriteLine();
            //CauD(list,sTimSV);


            ////Câu E : Sắp xếp danh sách theo Mã Sinh Viên
            //list.SelectionSort();
            //list.PrintList();

            //Câu F: Tìm thông tin của một sinh viên theo mã sinh viên 
            //Console.Write("Nhap ma SV ban muon tim : ");
            //string sTimSV = Console.ReadLine();
            //Node result = list.Find(sTimSV);
            //if (result == null)
            //{
            //    Console.WriteLine("Khong co sinh vien co maSV = {0} ton tai",sTimSV);
            //}
            //else
            //{
            //    Console.WriteLine("------------THONG TIN SINH VIEN CO MSV = {0}----------", sTimSV);
            //    result.Data.Print();
            //}

            //Câu G: Tìm và xóa sinh viên có mã sinh viên là x, với x nhập từ bàn phím.
            //Console.Write("Nhap ma SV ban muon tim : ");
            //string sTimSV = Console.ReadLine();
            //list.Remove(sTimSV);
            //list.PrintList();
            //Console.WriteLine("Danh sach co {0} sinh vien", list.Count);

            //Câu H: Cập nhật lại điểm trung bình của sinh viên có mã sinh viên là x, với x và điểm
            //mới được nhập từ bàn phím.
            //Console.Write("Nhap ma SV ban muon tim : ");
            //string sTimSV = Console.ReadLine();
            //Node p = list.Find(sTimSV);
            //if (p == null)
            //{
            //    Console.WriteLine("Khong co sinh vien co MaSV = {0}",sTimSV);
            //}
            //else
            //{
            //    Console.WriteLine("Nhap diem trung binh muon sua");
            //    double.TryParse(Console.ReadLine(), out double diem);
            //    p.Data.DiemTB = diem;
            //    list.PrintList();
            //}

            Console.ReadKey();
        }       
        //Câu D: Tìm tuần tự thông tin của một sinh viên theo mã sinh viên.
        static void CauD(LinkedList list, string key)
        {
            Node result = list.Find(key);
            Console.WriteLine("-----------THONG TIN SV CO MASV = {0}----------",key);
            result.Data.Print();
        }

        //Câu C : In ra danh sách các sinh viên có điểm trung bình lớn hơn hoặc bằng 5.
        static void CauC(LinkedList list)
        {
            Console.WriteLine("------------DANH SACH SV CO DTB >= 5--------------");
            for (Node p = list.First; p != null; p = p.Next)
            {
                if (p.Data.DiemTB >= 5)
                {
                    p.Data.Print();
                }
            }
        }
    }
}
