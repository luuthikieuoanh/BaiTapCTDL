using System;

namespace C4_BT5
{
    class C4_BT5
    {

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //Add Last
            list.AddLast("ABC");
            list.AddLast(123);
            list.AddLast(true);
            list.AddLast(1.5);
            //list.Print();

            //Add First
            list.AddFirst('Z');
            list.AddFirst('Y');
            list.AddFirst('X');
            //list.Print();

            //Add After
            list.AddAfter(list.Find(123), 345);
            list.AddAfter(list.Find(345), 456);
            list.AddAfter(list.Find(456), 789);
            //list.Print();

            ////Remove First
            //list.RemoveFirst();

            ////Remove Last
            //list.RemoveLast();

            //Remove After
            list.RemoveAfter(list.Find(456));
            //list.Print();

            //Remove
            list.Remove(true);
            //list.Print();

            //Clear
            //list.Clear();
            list.Print();

            Console.ReadKey();
        }
    }
}
