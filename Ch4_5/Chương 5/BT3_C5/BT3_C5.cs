using System;
using System.Collections.Generic;
using System.Reflection;

namespace BT3_C5
{
    class BT3_C5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi");
            string chuoi = Console.ReadLine();
            string[] input = chuoi.Split(" ", StringSplitOptions.None);

            ListStack st = new ListStack();

            Console.WriteLine("Ket qua = {0}", YeuCau(input, st));

            Console.ReadKey();
        }
        static int YeuCau(string[] chuoi, ListStack st)
        {
            int kq = 0;
            for (int i = 0; i != chuoi.Length; i++)
            {
                if (chuoi[i] != " " && chuoi[i] != "+" && chuoi[i] != "-" && chuoi[i] != "*" && chuoi[i] != "/")
                {
                    int.TryParse(chuoi[i], out int iX);
                    st.Push(iX);
                
                }
                if (chuoi[i] == "+")
                {
                    int x = st.Pop();
                    int y = st.Pop();
                    kq = x + y;
                    st.Push(kq);
                }
                if (chuoi[i] == "-")
                {
                    int x = st.Pop();
                    int y = st.Pop();
                    kq = x - y;
                    st.Push(kq);
                }
                if (chuoi[i] == "*")
                {
                    int x = st.Pop();
                    int y = st.Pop();
                    kq = x * y;
                    st.Push(kq);
                }
                if (chuoi[i] == "/")
                {
                    int x = st.Pop();
                    int y = st.Pop();
                    kq = x / y;
                    st.Push(kq);
                }
            }
            return st.Peek();

        }
    }
}
