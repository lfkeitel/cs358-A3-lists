using System;

namespace AbstractDataTypes
{
    class OrderedLinkedList<T> : LinkedList<T> where T : IComparable<T>
    {
        public OrderedLinkedList()
        {
            head = null;
        }

        // Insert() method places one item in the list
        public override void Insert(T item)
        {
            Node n = new Node(item);

            // List is empty
            if (head == null)
            {
                head = n;
                return;
            }

            // New node is before or same as head
            if (head.data.CompareTo(n.data) >= 0)
            {
                n.next = head;
                head = n;
                return;
            }

            // New node is somewhere else in the list
            Node p = head;
            while (p != null)
            {
                // If there is no next node, new node is end of list
                if (p.next == null)
                {
                    p.next = n;
                    break;
                }

                // If the next node is larger, insert new node
                if (p.next.data.CompareTo(n.data) >= 0)
                {
                    n.next = p.next;
                    p.next = n;
                    break;
                }
                p = p.next;
            }
        }

        // Min() returns the smallest item in the list
        public override T Min()
        {
            if (head == null) return default(T);
            return head.data;
        }

        // Max() returns the largest item in the list
        public override T Max()
        {
            if (head == null) return default(T);
            Node max = head;
            // Fast forward therough list since tail is not kept
            while (max.next != null)
            {
                max = max.next;
            }
            return max.data;
        }

        // This class is already sorted, so simply return this.
        public override IList<T> Sort()
        {
            return this;
        }
    }
}
