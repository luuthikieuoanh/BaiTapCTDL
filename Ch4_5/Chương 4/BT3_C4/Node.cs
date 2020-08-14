using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_C4
{
    class Node
    {
        internal SinhVien Data;
        internal Node Next;

        public Node(SinhVien value)
        {
            Data = value;
            Next = null;
        }
    }
}
