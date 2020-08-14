using System;
using System.Collections.Generic;
using System.Text;

namespace BT2_C5
{
    class Node
    {
        internal char Data; //giá trị của phần tử
        internal Node Next; //con trỏ Next trỏ tới phần tử kế tiếp
                            //hàm khởi tạo
        public Node(char value)
        {
            Data = value;
            Next = null;
        }
    }
}
