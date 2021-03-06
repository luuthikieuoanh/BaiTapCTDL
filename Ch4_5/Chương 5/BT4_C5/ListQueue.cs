﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT4_C5
{
    class ListQueue
    {
        //Fields
        private Node _front;
        private Node _rear;
        private int _size;


        //Properties
        public int Count { get => _size; set => _size = value; }
        internal Node Front { get => _front; set => _front = value; }
        internal Node Rear { get => _rear; set => _rear = value; }

        //Constructors
        public ListQueue()
        {
            _front = _rear = null;
            _size = 0;
        }

        //Methods
        public void EnQueue(HangHoa data)
        {
            Node newNode = new Node(data);

            if (newNode == null)
            {
                throw new Exception("Khong the them vao queue");
            }
            if (_front == null)
            {
                _front = _rear = newNode;
            }
            else
            {
                _rear.Next = newNode;
                _rear = newNode;
            }
            _size++;
        }

        public HangHoa DeQueue()
        {
            if (_front == null)
            {
                throw new Exception("Queue Rong");
            }
            Node temp = _front;
            _front = temp.Next;
            _size--;

            HangHoa temphh = temp.Data;
            temp = null;
            if (_front == null)
            {
                _rear = null;
            }
            return temphh;
        }

        public HangHoa Peek()
        {
            if (_front == null)
            {
                throw new Exception("Queue Rong");
            }
            return _front.Data;
        }

        public void Clear()
        {       
            _size = 0;
            _rear = _front = null;
        }

        public void Display()
        {
            if (_front == null)
            {
                throw new Exception("Queue Rong");
            }
            Node p = _front;
            while (p != null)
            {
                p.Data.Display();
                p = p.Next;
            }
            Console.WriteLine();
        }

    }
}
