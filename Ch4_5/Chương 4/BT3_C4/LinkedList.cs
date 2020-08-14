using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BT3_C4
{
    class LinkedList : SinhVien
    {
        //Fields
        private Node _first;
        private Node _last;
        private int _size;

        //Properties
        public int Count { get => _size; }
        internal Node First { get => _first; set => _first = value; }
        internal Node Last { get => _last; }

        //Constructors
        public LinkedList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }

        //Methods
        //Print
        public void PrintList()
        {
            Node p = _first;
            while (p != null)
            {
                p.Data.Print();
                p = p.Next;
            }
        }

        //AddLast
        public void AddLast(SinhVien data)
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

        //AddFirst
        public void AddFirst(SinhVien data)
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

        //AddAfter
        public void AddAfter(Node pre, SinhVien data)
        {
            Node newNode = new Node(data);
            if (pre != null)
            {
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                }
                _size++;
            }
        }

        //Remove Last
        public void RemoveLast()
        {
            if (_first == _last)
            {
                _first = _last = null;
                _size = 0;
            }

            Node pre = _first;
            while (pre.Next != _last)
            {
                pre = pre.Next;
            }
            pre.Next = null;
            _last = pre;
            _size--;
        }

        //Remove First
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

        //Remove After
        public void RemoveAfter(Node pre)
        {
            Node del = pre.Next;
            if (pre != null)
            {
                pre.Next = del.Next;
                if (pre.Next == null)
                {
                    _last = pre;
                }
                _size--;
            }
        }

        //Remove 
        public void Remove(string maSV)
        {
            if (_first.Data.MaSV == maSV)
            {
                RemoveFirst();
            }
            else
            {
                Node pre = _first;
                while (pre.Next.Data.MaSV != maSV && pre.Next != null)
                {
                    pre = pre.Next;
                }

                if (pre != null)
                {
                    Node del = pre.Next;
                    if (pre != null)
                    {
                        pre.Next = del.Next;
                        if (pre.Next == null)
                        {
                            _last = pre;
                        }
                        _size--;
                    }
                }
            }

        }

        //Find
        public Node Find(string maSV)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.MaSV == maSV)
                {
                    return p;
                }
            }
            return null;
        }

        //Selection Sort theo maSV
        public void SelectionSort()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Node Min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (string.Compare(Min.Data.MaSV, q.Data.MaSV) == 1)
                    {
                        Min = q;
                    }
                }
                SinhVien Tam = Min.Data;
                Min.Data = p.Data;
                p.Data = Tam;
            }
        }

        //Nhập dữ liêu cho mảng
        public LinkedList NhapDLlist()
        {
            int iN = 0;
            Console.Write("Nhap so luong sinh vien: ");
            int.TryParse(Console.ReadLine(), out iN);
            Console.WriteLine();
            if (iN == 0)
            {
                return new LinkedList();
            }

            LinkedList result = new LinkedList();
            for (int i = 0; i < iN; i++)
            {
                result.AddLast(NhapDLSV());
            }
            return result;
        }
    }
}
