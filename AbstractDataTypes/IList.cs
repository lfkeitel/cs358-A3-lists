using System;

namespace AbstractDataTypes
{
    interface IList<T>
    {
        // Insert() method places one item in the list
        void Insert(T item);
        // Remove() method removes first instance of item in list
        void Remove(T item);
        // RemoveAll() method removes all instances of item in the list
        void RemoveAll(T item);
        // Print() method prints all items in list
        void Print();
        // Min() returns the smallest item in the list
        T Min();
        // Max() returns the largest item in the list
        T Max();
        // Sort() sorts the list and will return an OrderedLinkedList
        IList<T> Sort();
    }
}
