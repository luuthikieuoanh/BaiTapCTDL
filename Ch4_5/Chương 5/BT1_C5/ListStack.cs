using System;
using System.Collections.Generic;
using System.Text;

namespace BT1_C5
{
    class ListStack
    {
        private Node _top; //con trỏ _top trỏ tới đỉnh Stack
                          
        private int _size;

        //Thuộc tính Count cho biết số phần tử có trong Stack
        public int Count
        {
            get
            {
                return _size;
            }
        }

        internal Node Top { get => _top; set => _top = value; }

        //Constructors
        /*
        * Khởi tạo stack
        */
        public ListStack()
        {
            Top = null;
            _size = 0;
        }

        //Methods
        /*
        * Hàm đẩy một phần tử vào đỉnh stack
        * Tham số value: dữ liệu của phần tử cần thêm
        * Nếu tạo node mới thất bại thì thông báo ngoại lệ
        */
        public void Push(int value)
        {
            Node pNew = new Node(value); //tạo node mới
            if (pNew == null)
                throw new Exception("Khong the them vao stack");
            //nếu stack rỗng
            if (Top == null)
                Top = pNew;
            else
            {
                pNew.Next = Top;
                Top = pNew;
            }
            _size++;
        }

        /*
        * Lấy một phần tử ra khỏi đỉnh stack
        * Return: Giá trị phần tử vừa lấy ra, nếu stack rỗng thì thông báo
        ngoại lệ
        */
        public int Pop()
        {
            if (Top == null)
                throw new Exception("Stack rong");
            //lấy giá trị và tách phần tử đỉnh stack ra khỏi stack
            Node pTemp = Top;
            Top = pTemp.Next;
            int temp = pTemp.Data;
            _size--;
            pTemp = null;
            return temp;
        }

        /*
        * Xem giá trị phần tử trên đỉnh stack
        * return: Giá trị phần tử đang ở trên đỉnh stack, nếu stack rỗng
        thì thông báo ngoại lệ
        */
        public int Peek()
        {
            if (Top == null)
                throw new Exception("Stack rong");
            return Top.Data;
        }
        /*
        * Kiểm tra stack rỗng hay không
        * Return: true nếu stack rỗng, false nếu stack khác rỗng
        */
        public bool IsEmpty()
        {
            return (Top == null);
        }
        /*
        * Hiển thị toàn bộ Stack
        */
        public void Display()
        {
            if (IsEmpty())
                Console.WriteLine("Stack rong!");
            else
            {
                Node p = Top;
                while (p != null)
                {
                    Console.Write("{0}\t",p.Data);
                    p = p.Next;
                }
                Console.WriteLine("\nStack co {0} phan tu",Count);
            }
        }
        /*
        * Hủy stack
        */
        public void Clear()
        {
            Node tempNode;
            while (Top != null)
            {
                tempNode = Top;
                Top = tempNode.Next;
                tempNode = null;
            }
            _size = 0;
        }
    }
}
