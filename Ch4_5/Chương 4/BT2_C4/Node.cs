using System;
using System.Collections.Generic;
using System.Text;

namespace BT2_C4
{
    class Node
    {
        internal int Data;
        internal Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

    }
}
