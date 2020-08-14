using System;
using System.Collections.Generic;
using System.Text;

namespace BT1_C4
{
    class LinkedList
    {
        private Node _first;
        private Node _last;
        private int _size;

        public int Count { get => _size; }
        internal Node First { get => _first; }
        internal Node Last { get => _last; }

        public LinkedList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }

        //Methods
        //Xuất toàn bộ thông tin ra màn hình
        public void PrintList()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.Write("{0}\t", p.Data);
            }
            Console.WriteLine();
        }

        //Thêm ở đầu danh sách
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (_first == null)
            {
                _first = _last = newNode;
            }
            else
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _size++;
        }

        //Thêm ở cuối danh sách
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (_first == null)
            {
                _first = _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }

        //Tìm kiếm tuần tự
        public Node Find(int key)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data == key)
                {
                    return p;
                }
            }
            return null;
        }

        //Sắp xếp tăng dần
        public void InretchangeSort()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data > q.Data)
                    {
                        int Tam = p.Data;
                        p.Data = q.Data;
                        q.Data = Tam;
                    }
                }
            }
        }
    }
}

