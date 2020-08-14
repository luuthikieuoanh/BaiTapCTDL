using C4_BT6;
using System;
using System.Collections.Generic;
using System.Text;

namespace C4_BT5
{
    class Node
    {
        internal PhanTuDaThuc Data;
        internal Node Next;

        public Node(PhanTuDaThuc data)
        {
            Data = data;
            Next = null;
        }
    }
}
