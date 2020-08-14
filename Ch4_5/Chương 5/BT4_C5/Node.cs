using System;
using System.Collections.Generic;
using System.Text;

namespace BT4_C5
{
    class Node
    {
        internal HangHoa Data;
        internal Node Next;

        public Node(HangHoa data)
        {
            Data = data;
            Next = null;
        }
    }
}
