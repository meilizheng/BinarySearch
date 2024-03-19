using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class DoubleLink
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node head;
        private Node tail;

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                // If the list is empty, set the new node as both head and tail
                head = newNode;
                tail = newNode;
            }
            else
            {
                // Append the new node to the end of the list
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }
    }

}
