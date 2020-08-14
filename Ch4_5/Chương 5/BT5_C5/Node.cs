using System;
using System.Collections.Generic;
using System.Text;

namespace BT5_C5
{
    class Node
    {
        internal object Data; //giá trị của phần tử
        internal Node Next; //con trỏ Next trỏ tới phần tử kế tiếp
                            //hàm khởi tạo
        public Node(object value)
        {
            Data = value;
            Next = null;
        }
    }
}
