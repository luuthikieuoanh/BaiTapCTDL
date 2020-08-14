using System;
using System.Collections.Generic;
using System.Text;

namespace C4_BT5
{
    class Node
    {
        internal object Data;
        internal Node Next;

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
