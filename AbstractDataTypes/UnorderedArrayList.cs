using System;

namespace AbstractDataTypes
{
    class UnorderedArrayList<T> : ArrayList<T> where T : IComparable<T>
    {
        public UnorderedArrayList() { }

        public override void Insert(T item)
        {
            if (next == list.Length) { throw new IndexOutOfRangeException(); }
            list[next] = item;
            next++;
        }

        public new void Remove(T item)
        {
            remove(item, false);
        }

        public override void RemoveAll(T item)
        {
            remove(item, true);
        }

        private void remove(T item, bool all)
        {
            if (next == 0) return;

            for (int i = 0; i < next; i++)
            {
                if (item.Equals(list[i]))
                {
                    list[i] = list[next - 1];
                    next--;
                    if (!all) return;
                    else i--; // Compare the same place in case the new element is the same
                }
            }
        }

        public override T Min()
        {
            if (next == 0) return default(T);

            T min = list[0];
            for (int i = 1; i < next; i++) {
                if (list[i].CompareTo(min) < 0) min = list[i];
            }
            return min;
        }

        public override T Max()
        {
            if (next == 0) return default(T);

            T max = list[0];
            for (int i = 1; i < next; i++)
            {
                if (list[i].CompareTo(max) > 0) max = list[i];
            }
            return max;
        }

        // Sort will take the items in the list and sort them by creating a new
        // OrderedLinkedList and inserting the items into the list.
        public override IList<T> Sort()
        {
            IList<T> l = new OrderedLinkedList<T>();

            for (int i = 0; i < next; i++)
            {
                l.Insert(list[i]);
            }
            return l;
        }
    }
}
