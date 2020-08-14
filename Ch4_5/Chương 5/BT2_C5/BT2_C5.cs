using System;
using System.Reflection.Metadata.Ecma335;

namespace BT2_C5
{
    class BT2_C5
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi muon check");
            string chuoi = Console.ReadLine();

            ListStack st = new ListStack();

            Console.WriteLine(YeuCau(chuoi, st));

            Console.ReadKey();
        }
        static bool YeuCau(string s, ListStack st)
        {
            foreach (char item in s)
            {

                if ((item == ')' || item == ']' || item == '}') && st.IsEmpty())
                {
                    return false;
                }

                 if (item == '(' || item == '[' || item == '{')
                {
                    st.Push(item);
                }

                //else if (item == ')' && st.Peek() == '('
                //    || item == ']' && st.Peek() == '['
                //    || item == '}' && st.Peek() == '}')
                //{
                //    st.Pop();
                //    st.Display();
                //}

                if (item == ')' && st.Peek() != '(') return false;
                if (item == '}' && st.Peek() != '{') return false;
                if (item == ']' && st.Peek() != '[') return false;

            }
            return st.IsEmpty();
        }
    }
}
