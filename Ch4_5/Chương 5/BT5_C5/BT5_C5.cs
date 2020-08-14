using System;

namespace BT5_C5
{
    class BT5_C5
    {


        static void Main(string[] args)
        {
            ListStack stack = new ListStack();

            //Add Dữ liệu
            stack.Push(123);
            stack.Push("Hung");
            stack.Push(6.9);
            stack.Push(true);
            stack.Push('A');

            Display(stack);

            //Peek
            Console.WriteLine("Peek = {0}",stack.Peek());
            Display(stack);

            //Pop
            Console.WriteLine("Pop = {0}",stack.Pop());
            Display(stack);

            Console.ReadKey();
        }
        //Displaay
        static void Display(ListStack stack)
        {
            for (Node p = stack.Top; p != null; p = p.Next)
            {
                Console.Write("{0,-15}",p.Data);
            }
            Console.WriteLine();
        }
    }
}
