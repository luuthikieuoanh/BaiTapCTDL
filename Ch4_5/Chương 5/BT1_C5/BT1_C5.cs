
using System;

namespace BT1_C5
{
    class BT1_C5
    {
 
        static void Main(string[] args)
        {
            Console.Write("Nhap so ban muon chuyen sang co so 2 : ");
            int.TryParse(Console.ReadLine(), out int iX);

            int iTam = iX;

            ListStack st = new ListStack();

            while (iTam != 0)
            {
                int ithuong = iTam % 2;
                st.Push(ithuong);
                iTam /= 2;
            }

            string sKQ = "";
            //Nối chuỗi
            for (Node p = st.Top; p != null; p = p.Next)
            {
                sKQ += st.Pop().ToString();
            }

            Console.WriteLine("{0} duoc chuyen qua thanh {1}", iX, sKQ);

            Console.ReadKey();
        }
    }
}
