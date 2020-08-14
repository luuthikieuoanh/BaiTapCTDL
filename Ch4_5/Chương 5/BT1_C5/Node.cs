using System;
using System.Collections.Generic;
using System.Text;

namespace BT1_C5
{
    class Node
    {
        internal int Data; //giá trị của phần tử
        internal Node Next; //con trỏ Next trỏ tới phần tử kế tiếp
                            //hàm khởi tạo
        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }
}
