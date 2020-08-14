using C4_BT6;
using System;
using System.Collections.Generic;
using System.Text;

namespace C4_BT5
{
    class LinkedList
    {
        //Fields
        private Node _first;
        private Node _last;
        private int _size;

        //Properties
        public int Count { get => _size; set => _size = value; }
        internal Node First { get => _first; set => _first = value; }
        internal Node Last { get => _last; set => _last = value; }

        //Constructors
        public LinkedList()
        {
            First = Last = null;
            _size = 0;
        }



        //Methods
        //Print
        public void Print()
        {
            Node p = _first;
            while (p != null)
            {
                Console.Write("{0,-10}", p.Data.XuatPTDaThuc());
                p = p.Next;

                if (p != null)
                {
                    if (p.Data.heso >= 0)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }
            Console.WriteLine();
        }

        //Add Last
        public void AddLast(PhanTuDaThuc data)
        {
            Node p = new Node(data);

            if (_first == null)
            {
                _first = _last = p;
            }
            else
            {
                _last.Next = p;
                _last = p;
            }
            _size++;
        }

        //Add First
        public void AddFirst(PhanTuDaThuc data)
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

        //Find
        public Node Find(object data)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.Equals(data))
                {
                    return p;
                }
            }
            return null;
        }

        //Add After
        public void AddAfter(Node pre, PhanTuDaThuc data)
        {
            if (pre != null)
            {
                Node newNode = new Node(data);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                }
                _size++;
            }

        }

        //Remove First
        public void RemoveFirst()
        {
            if (_first != null)
            {
                _first = _first.Next;

                if (_first == null)
                {
                    _last = null;
                }
                _size--;
            }
        }

        //Remove Last
        public void RemoveLast()
        {
            if (_first != null)
            {
                if (_first == _last)
                {
                    _first = _last = null;
                    _size = 0;
                }
                else
                {
                    Node pre = null;
                    for (pre = _first; pre.Next != _last; pre = pre.Next)
                    {

                    }
                    pre.Next = null;
                    _last = pre;
                    _size--;
                }
            }
        }

        //Remove After
        public void RemoveAfter(Node pre)
        {
            if (pre != null)
            {
                Node del = pre.Next;
                if (del != null)
                {
                    pre.Next = del.Next;
                    if (del == _last)
                    {
                        _last = pre;
                    }
                    _size--;
                }
            }
        }

        //Remove
        public void Remove(object data)
        {
            if (_first.Data.Equals(data))
            {
                RemoveFirst();
            }
            else
            {
                Node pre = null;

                for (pre = _first; pre.Next != null; pre = pre.Next)
                {
                    if (pre.Next.Data.Equals(data))
                    {
                        break;
                    }
                }
                RemoveAfter(pre);
            }
        }

        //Remove All
        public void Clear()
        {
            Node p = _first;
            while (p != null)
            {
                RemoveFirst();
                p = p.Next;
            }
        }

        //Nhập đa thức
        public void NhapDaThuc(int iBacDaThuc)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nhap he so giam dan theo so mu");
            Console.WriteLine("VD : 3X^2 + 5");
            Console.WriteLine("Ban phai nhap he so lan luot la 3, 0 ,5");
            Console.ResetColor();
            for (int i = iBacDaThuc; i >= 0; i--)
            {
                PhanTuDaThuc x = new PhanTuDaThuc();
                Console.WriteLine("Nhap he so Phan tu bac {0} cua da thuc bac {1}", i, iBacDaThuc);
                x.NhapPTDaThuc(i);
                AddLast(x);
            }
        }

        //TÍNH ĐẠO HÀM ĐA THỨC
        public void TinhDaoHam()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                //Đạo hàm 1 hàng số = chính nó, nên cần sét trường hợp khác 0 mới thực hiện thay đổi số mũ và cơ số
                if (p.Data.somu != 0)
                {
                    p.Data = new PhanTuDaThuc(p.Data.heso * p.Data.somu, p.Data.somu - 1);
                }            
            }
        }
    }
}
