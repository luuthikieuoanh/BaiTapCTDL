using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BT2_C4
{
    class BT2_C4
    {
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            int iNA = 0;
            Console.WriteLine("Nhap so phan tu cua mang A");
            int.TryParse(Console.ReadLine(), out iNA);

            listA = TaoList(listA, iNA);
            Console.Write("\nList A :");
            listA.PrintList();

            LinkedList listB = new LinkedList();
            int iNB = 0;
            Console.WriteLine("Nhap so phan tu cua mang B");
            int.TryParse(Console.ReadLine(), out iNB);

            listB = TaoList(listB, iNB);
            Console.Write("\nList B :");
            listB.PrintList();

            LinkedList listC = new LinkedList();

            // Tạo danh sách L3 bằng cách nối L2 vào sau L1
            //listC = CauA(listA, listB, listC);
            //Console.Write("List C :");
            //listC.PrintList();
            //Console.WriteLine("Sau khi cap nhap du lieu:");
            //Console.Write("\nList A :");
            //listA.PrintList();
            //Console.Write("\nList B :");
            //listB.PrintList();
            //if (listC.First == null)
            //{
            //    Console.WriteLine("First = Last = null");
            //}
            //else
            //{
            //    Console.WriteLine("First = {0}", listC.First.Data);
            //    Console.WriteLine("Last = {0}", listC.Last.Data);
            //    Console.WriteLine("So phan tu = {0}", listC.Count);
            //}


            ////Tạo danh sách L3 bao gồm các phần tử chỉ có trong L1 mà không có trong L2
            //listC = CauB(listA, listB, listC);
            //listC.PrintList();
            //if (listC.First == null)
            //{
            //    Console.WriteLine("First = Last = null");
            //}
            //else
            //{
            //    Console.WriteLine("First = {0}", listC.First.Data);
            //    Console.WriteLine("Last = {0}", listC.Last.Data);
            //    Console.WriteLine("So phan tu = {0}", listC.Count);
            //}


            ////Tạo danh sách L3 bao gồm các phần tử vừa có trong L1 vừa có trong L2
            //listC = CauC(listA, listB, listC);
            //listC.PrintList();
            //if (listC.First == null)
            //{
            //    Console.WriteLine("First = Last = null");
            //}
            //else
            //{
            //    Console.WriteLine("First = {0}", listC.First.Data);
            //    Console.WriteLine("Last = {0}", listC.Last.Data);
            //    Console.WriteLine("So phan tu = {0}", listC.Count);
            //}

            //Tạo danh sách L3 bao gồm các phần tử hoặc có trong L1 hoặc có trong L2
            //listC = CauD(listA, listB, listC);
            //listC.PrintList();
            //if (listC.First == null)
            //{
            //    Console.WriteLine("First = Last = null");
            //}
            //else
            //{
            //    Console.WriteLine("First = {0}", listC.First.Data);
            //    Console.WriteLine("Last = {0}", listC.Last.Data);
            //    Console.WriteLine("So phan tu = {0}", listC.Count);
            //}

            //Câu E
            //listC = CauE(listA, listB, listC);
            //Console.Write("List C :");
            //listC.PrintList();
            //Console.WriteLine("Sau khi cap nhap du lieu:");
            //Console.Write("\nList A :");
            //listA.PrintList();
            //Console.Write("\nList B :");
            //listB.PrintList();

            //Câu F : Kiểm tra 2 danh sách L1 và L2 có trùng giá trị hay không?
            //Console.WriteLine("L1 co trung L2 khong = {0}", CauF(listA, listB));

            //Câu G : Xóa một phần tử đầu tiên được tìm thấy trong L1 thõa mãn điều kiện: Giá trị của
            //nó lớn hơn tổng giá trị phần tử của L2.
            //listA = CauG(listA, listB);
            //listA.PrintList();

            //Câu H:Xóa tất cả các phần tử trong L1 có giá trị bằng giá trị lớn nhất trong L2
            //listA = CauH(listA, listB);
            //listA.PrintList();

            Console.ReadKey();
        }
        //Câu H:Xóa tất cả các phần tử trong L1 có giá trị bằng giá trị lớn nhất trong L2
        static LinkedList CauH(LinkedList listA, LinkedList listB)
        {
            if (listB.First == null)
            {
                return listA;
            }
            int Max = listB.First.Data;


            //Tìm Max trong listB
            for (Node p = listB.First; p != null; p = p.Next)
            {
                if (p.Data > Max)
                {
                    Max = p.Data;
                }
            }

            for (Node p = listA.First; p != listA.Last; p = p.Next)
            {
                if (p.Next.Data == Max)
                {
                    listA.RemoveAfter(p);
                }
            }
            return listA;
        }

        //Câu G : Xóa một phần tử đầu tiên được tìm thấy trong L1 thõa mãn điều kiện: Giá trị của
        //nó lớn hơn tổng giá trị phần tử của L2.
        static LinkedList CauG(LinkedList listA, LinkedList listB)
        {
            if (listB.First == null)
            {
                return listA;
            }

            int S = 0;
            for (Node p = listB.First; p != null; p = p.Next)
            {
                S += p.Data;
            }

            for (Node p = listA.First; p != null; p = p.Next)
            {
                if (p.Data > S)
                {
                    listA.Remove(p.Data);
                    break;
                }
            }

            return listA;
        }


        //Câu F : Kiểm tra 2 danh sách L1 và L2 có trùng giá trị hay không?
        static bool CauF(LinkedList listA, LinkedList listB)
        {
            if (listA.Count != listB.Count)
            {
                return false;
            }
            else
            {
                for (Node p = listA.First, q = listB.First; p != null && q != null; p = p.Next , q = q.Next)
                {
                    if (p.Data != q.Data)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Câu E
        static LinkedList CauE(LinkedList listA, LinkedList listB, LinkedList listC)
        {
            Node p = listA.First;
            Node q = listB.First;

            while (p != null || q != null)
            {
                if (p != null && q != null)
                {
                    listC.AddLast(p.Data + q.Data);
                    p = p.Next;
                    q = q.Next;
                }
                else if (p == null)
                {
                    listC.AddLast(q.Data);
                    q = q.Next;
                }
                else
                {
                    listC.AddLast(p.Data);
                    p = p.Next;
                }
            }

            return listC;
        }

        //Tạo danh sách L3 bao gồm các phần tử hoặc có trong L1 hoặc có trong L2
        static LinkedList CauD(LinkedList listA, LinkedList listB, LinkedList listC)
        {

            for (Node p = listA.First; p != null; p = p.Next)
            {
                listC.AddLast(p.Data);
            }

            //Tìm các phần tử trong listB không có trong list A, sau đó thêm vào listC
            for (Node q = listB.First; q != null; q = q.Next)
            {
                if (listA.Find(q.Data) == null)
                {
                    listC.AddLast(q.Data);
                }
            }

            return listC;
        }

        //Tạo danh sách L3 bao gồm các phần tử vừa có trong L1 vừa có trong L2
        static LinkedList CauC(LinkedList listA, LinkedList listB, LinkedList listC)
        {
            for (Node p = listA.First; p != null; p = p.Next)
            {
                if (listB.Find(p.Data) != null)
                {
                    listC.AddLast(p.Data);
                }
            }
            return listC;
        }

        //Tạo danh sách L3 bao gồm các phần tử chỉ có trong L1 mà không có trong L2
        static LinkedList CauB(LinkedList listA, LinkedList listB, LinkedList listC)
        {
            for (Node p = listA.First; p != null; p = p.Next)
            {
                if (listB.Find(p.Data) == null)
                {
                    listC.AddLast(p.Data);
                }
            }
            return listC;
        }

        // Tạo danh sách L3 bằng cách nối L2 vào sau L1
        static LinkedList CauA(LinkedList listA, LinkedList listB, LinkedList listC)
        {

            for (Node p = listA.First; p != null; p = p.Next)
            {
                listC.AddLast(p.Data);
            }

            for (Node p = listB.First; p != null; p = p.Next)
            {
                listC.AddLast(p.Data);
            }

            return listC;
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

