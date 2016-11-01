using System;

namespace AbstractDataTypes
{
    abstract class LinkedList<T> : IList<T> where T : IComparable<T>
    {
        protected Node head;

        public LinkedList()
        {
            head = null;
        }

        // Insert() method places one item in the list
        public virtual void Insert(T item)
        {
            Node n = new Node(item);

            // List is empty
            if (head == null)
            {
                head = n;
                return;
            }

            n.next = head;
            head = n;
        }

        // Remove() method removes first instance of item in list
        public void Remove(T item)
        {
            remove(item, false);
        }

        // RemoveAll() method removes all instances of item in the list
        public void RemoveAll(T item)
        {
            remove(item, true);
        }

        private void remove(T item, bool all)
        {
            if (head == null) { return; }

            Node pre, p;
            pre = p = head; // Init previous and p
            while (p != null)
            {
                if (p.data.CompareTo(item) == 0)
                {
                    pre.next = p.next;
                    if (p == head) // If the compared node was the head, set new head
                    {
                        head = p.next;
                    }
                    if (!all) return; // If we're not removing all values, return
                    p = p.next;
                    continue;
                }
                // Preserve the previous node and set next node
                pre = p;
                p = p.next;
            }
        }

        // Print() method prints all items in list
        public void Print() {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data+" ");
                p = p.next;
            }
        }

        // Min() returns the smallest item in the list
        public abstract T Min();

        // Max() returns the largest item in the list
        public abstract T Max();

        // This class is already sorted, so simply return this.
        public abstract IList<T> Sort();

        protected class Node
        {
            public Node next;
            public T data;

            public Node(T d)
            {
                data = d;
                next = null;
            }
        }
    }
}
