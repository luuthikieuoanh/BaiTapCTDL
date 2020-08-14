using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BT2_C4
{
    class LinkedList
    {
        private Node _first;
        private Node _last;
        private int _size;

        public int Count { get => _size; set => _size = value; }
        internal Node First { get => _first; set => _first = value; }
        internal Node Last { get => _last; set => _last = value; }

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

        //Thêm vào giữa danh sách
        public void AddAfter(Node pre, int data)
        {
            Node p = new Node(data);


            if (pre != null)
            {
                p.Next = pre.Next;
                pre.Next = p;
                if (pre == _last)
                {
                    _last = p;
                }
                _size++;
            }

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
        public void InterchangeSort()
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

        //Xóa đầu danh sách
        public void RemoveFirst()
        {
            Node p = _first;
            if (p != null)
            {
                _first = p.Next;
                if (_first == null)
                {
                    _last = null;
                }
                _size--;
            }

        }

        //Xóa cuối danh sách
        public void RemoveLast()
        {
            if (_first == _last)
            {
                _first = null;
                _last = null;
                _size = 0;
            }
            else
            {
                Node p = null;
                for (p = _first; p.Next == _last; p = p.Next)
                {

                }
                p.Next = null;
                _last = p;
                _size--;

            }
        }

        //Xóa  phần tử bằng giá trị cho trước
        public void Remove(int data)
        {
            if (_first.Data == data)
            {
                RemoveFirst();
            }
            else
            {
                Node pre = _first;
                while (pre.Next != null && pre.Next.Data != data)
                {
                    pre = pre.Next;
                }

                //if (pre != null)
                //{
                //    Node del = pre.Next;
                //    if (del != null)
                //    {
                //        pre.Next = del.Next;
                //        if (pre.Next == null)
                //        {
                //            _last = pre;
                //        }
                //        _size--;
                //    }
                //}

                RemoveAfter(pre);
            }
        }


        //Xoa mot phan tu sau mot phan tu khac
        public void RemoveAfter(Node pre)
        {
            Node del;
            if (pre != null)
            {
                del = pre.Next;
                if (del != null)
                {
                    pre.Next = del.Next;
                    if (pre.Next == null)
                        _last = pre;
                    _size--;
                }
            }
        }

        //Đếm số lần xuất hiện của 1 phần tử
        public int CountValue( int value)
        {
            int Count = 0;
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data == value)
                {
                    Count++;
                }
            }
            return Count;
        }
        
        //Xóa tất cả phần tử
        public void RemoveAll()
        {
            _first = _last = null;
            _size = 0;
        }
    }
}
