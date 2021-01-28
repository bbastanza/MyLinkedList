using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class MyLinkedList
    {
        private Node _head;
        private Node _tail;
        private int _size = 0;

        public void ReadList()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty");

            var currentNode = _head;
            
            while (true)
            {
                Console.WriteLine(currentNode.Value);
                
                if (currentNode.Next == null)
                    return;
                
                currentNode = currentNode.Next;
            }
        }

        public int IndexOf(int value)
        {
            if (IsEmpty())
            {
                return -1;
            }

            var currentNode = _head;

            var index = 0;

            while (true)
            {
                if (currentNode.Value == value)
                {
                    return index;
                }

                if (currentNode.Next == null)
                {
                    return -1;
                }

                currentNode = currentNode.Next;
                index++;
            }
        }


        public void AddFirst(int value)
        {
            var newNode = new Node(value);
            if (IsEmpty())
            {
                _head = _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }

            _tail ??= newNode;
            _size++;
        }

        public void AddLast(int value)
        {
            var newNode = new Node(value);
            if (IsEmpty())
            {
                _head = _tail =  newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _size++;
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;

        }

        public void DeleteFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty");

            _size--;
            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                var head = _head.Next;
                _head = head;
            }
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty");

            _size--;
            if (_head == _tail)
            {
               _head = _tail = null;
            }
            
            var currentNode = _head;
            
            while (true)
            {
                if (currentNode.Next.Next == null)
                {
                    _tail = currentNode;
                    _tail.Next = null;
                    return;
                }
                
                currentNode = currentNode.Next;
            }
        }

        private bool IsEmpty()
        {
            return _head == null;
        }

        public int Size()
        {
            return _size;
        }

        public List<int> ToGenericList()
        {
            var currentNode = _head;
            var list = new List<int>();
            while (list.Count < _size)
            {
                list.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return list;
        }
    }
}