using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures.All
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddToFront(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = node;
            }
        }
    }

    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
}
