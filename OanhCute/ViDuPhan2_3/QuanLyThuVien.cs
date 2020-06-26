using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTThucHanh2_3
{
    public struct Book
    {
        public string IDBook;
        public string BookName;
        public int Publishing;
        public long Price;

        public Book(string idBook, string bookName, int publishing, long price)
        {
            this.IDBook = idBook;
            this.BookName = bookName;
            this.Publishing = publishing;
            this.Price = price;
        }
    }

    class QuanLyThuVien
    {
        static void Main(string[] args)
        {
            int soPT = 0;
            
                Console.Write("Nhap so luong sach: ");
            int.TryParse(Console.ReadLine(), out soPT);
            Book[] book = new Book[soPT];

            for (int i = 0; i < book.Length; i++)
            {
                Console.Write("===============\n");
                Console.WriteLine("Thong tin book {0}: ", i);
                book[i] = NhapThongTinSach();
            }

            Console.WriteLine("\nIn thong tin sach: ");
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine("Sach thu {0}: ", i);
                Console.WriteLine(InThongTinSach(book[i]));
            }

            //Console.Write("Nhap vao tua sach can tim: ");
            //string tuaKey = Console.ReadLine();

            //for (int i = 0; i < book.Length; i++)
            //{
            //    if (TimKiemTuaSach(book[i], tuaKey) == true)
            //    {
            //        Console.WriteLine("Thong tin cua sach {0} la: ", tuaKey);
            //        Console.WriteLine(InThongTinSach(book[i]));
            //        Console.Write("Nhap vao gia sach muon thay doi: ");
            //        long.TryParse(Console.ReadLine(), out book[i].Price);
            //        Console.WriteLine("Sach sau khi thay doi gia la: ");
            //        Console.WriteLine(InThongTinSach(book[i]));
            //    }
            //}

            //Console.Write("Nhap vao ma sach can tim: ");
            //string maKey = Console.ReadLine();
            //int viTriMaSach = TimKiemMaSach(book, maKey);
            //if (TimKiemMaSach(book, maKey) == -1)
            //{
            //    Console.WriteLine("Thu vien khong co ma sach {0} nay", maKey);
            //}
            //else
            //{
            //    Console.WriteLine("Ma sach {0} can tim la: ", maKey);
            //    Console.WriteLine(InThongTinSach(book[viTriMaSach]));
            //    Console.WriteLine("Danh sach sau khi xoa sach co ma {0}: ", maKey);
            //    Book[] newbook = XoaBook(book, viTriMaSach);
            //    for (int i = 0; i < newbook.Length; i++)
            //    {
            //        Console.WriteLine("Sach thu {0}: ", i);
            //        Console.WriteLine(InThongTinSach(newbook[i]));
            //    }
            //}

            //Console.WriteLine("Danh sach cac cuon sach sau khi sap xep tang dan theo ma sach: ");
            //PrintInfoSach(SelectionSort(book));

            //Console.WriteLine("Danh sach cac cuon sach sau khi sap xep giam dan theo nam xuat ban: ");
            //PrintInfoSach(InsertionSort(book));

            //Console.WriteLine("Danh sach cac cuon sach sau khi sap xep tang dan theo tua sach: ");
            //PrintInfoSach(BubbleSort(book));

            Console.WriteLine(" Danh sach cac cuon sach sau khi sap xep giam dan theo gia sach: ");
            PrintInfoSach(QuickSort(book, 0, book.Length - 1));

            Console.ReadKey();
        }

        static Book NhapThongTinSach()
        {

            string iD = "";
            string name = "";
            int pub = 0;
            long pri = 0;
            do
            {
                Console.Write("\tNhap ma sach: ");
                iD = Console.ReadLine();
            } while (iD.Length > 6);

            do
            {
                Console.Write("\tNhap tua sach: ");
                name = Console.ReadLine();
            } while (name.Length > 30);

            do
            {
                Console.Write("\tNhap nam xuat ban: ");
                int.TryParse(Console.ReadLine(), out pub);
            } while (pub <= 1900);

            do
            {
                Console.Write("\tNhap vao gia: ");
                long.TryParse(Console.ReadLine(), out pri);
            } while (pri >= 10000000 || pri < 0);
            Book book = new Book(iD, name, pub, pri);
            return book;
        }

        static void PrintInfoSach(Book[] book)
        {
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine("Sach {0}: ", i);
                Console.WriteLine("\tMa sach: {0}", book[i].IDBook);
                Console.WriteLine("\tTua sach: {0}", book[i].BookName);
                Console.WriteLine("\tNam xuat ban sach: {0}", book[i].Publishing);
                Console.WriteLine("\tGia sach: {0}", book[i].Price);
            }

        }

        static string InThongTinSach(Book book)
        {
            string result = $"\tMa sach: {book.IDBook} \n\tTua sach: {book.BookName} \n\tNam xuat ban: {book.Publishing} \n\tGia sach: {book.Price}";
            return result;
        }

        static bool TimKiemTuaSach(Book book, string tuaKey)
        {
            if (string.Equals(tuaKey, book.BookName))
            {
                return true;
            }
            return false;
        }

        static int TimKiemMaSach(Book[] book, string maKey)
        {
            string[] str = new string[book.Length];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = book[i].IDBook;
            }
            int viTri = 0;
            int left = 0;
            int right = book.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (String.Compare(str[mid], maKey) == 0)//str[mid]==makey
                {
                    viTri = mid;
                    return viTri;
                }
                else if (String.Compare(str[mid], maKey) == 1)//str[mid]==makey
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        static Book[] XoaBook(Book[] book, int viTriMaSach)
        {
            Book[] newbook = new Book[0];
            for (int i = 0; i < book.Length; i++)
            {
                if (i != viTriMaSach)
                {
                    Array.Resize(ref newbook, newbook.Length + 1);
                    newbook[newbook.Length - 1] = book[i];
                }
            }

            return newbook;
        }

        static Book[] SelectionSort(Book[] book)
        {
            int min = 0;
            for (int i = 0; i < book.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < book.Length; j++)
                {
                    if (String.Compare(book[j].IDBook, book[min].IDBook) == -1)
                    {
                        min = j; //luu vi tri thu nho nhat
                    }

                }
                //hoán vị idbook tại i và idbook tại j
                Swap(ref book[min], ref book[i]); //<Book> có thể có hoặc không swap tự động cập nhật dữ liệu
            }
            return book;
        }

        static void Swap<T>(ref T n1, ref T n2) //T là kiểu dữ liệu linh động
        {
            T temp = n1;
            n1 = n2;
            n2 = temp;
        }

        static Book[] InsertionSort(Book[] book)
        {
            int pos = 0;
            Book iPublishing;
            for (int i = 1; i < book.Length; i++)
            {
                iPublishing = book[i];
                pos = i - 1;
                while (pos >= 0 && iPublishing.Publishing > book[pos].Publishing)
                {
                    book[pos + 1] = book[pos];
                    pos--;
                }
                book[pos + 1] = iPublishing;
            }
            return book;
        }

        static Book[] BubbleSort(Book[] book)
        {
            //copy mang
            Book[] newbook = new Book[book.Length];
            Array.Copy(book, newbook, book.Length);
            bool check = false;
            //sap xep
            for (int i = 0; i < newbook.Length - 1 && !check; i++)
            {
                check = true;
                for (int j = newbook.Length - 1; j > i; j--)
                {
                    if (string.Compare(newbook[j].BookName, newbook[j - 1].BookName) == -1)
                    {
                        Swap(ref newbook[j], ref newbook[j - 1]);
                        check = false;
                    }
                }
            }
            return newbook;
        }

        static Book[] QuickSort(Book[] book,int left, int right)
        {
            if (left >= right) return book;
            int i = left;
            int j = right;
            int mid = (left + right) / 2;
            while (i<=j)
            {
                while (book[i].Price > book[mid].Price) i++;
                while (book[j].Price < book[mid].Price) j--;
                if (i<=j)
                {
                    Swap(ref book[j], ref book[i]);
                    i++;
                    j--;
                }
            }
            book=QuickSort(book, left, j);
            book=QuickSort(book, i, right);
            return book;
        }
    }

   





}
