using System;

namespace AbstractDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Int");
            testInt();

            Console.WriteLine("\nTest Double");
            testDouble();

            Console.WriteLine("\nTest String");
            testString();

            Console.ReadKey();
        }

        private static void testInt()
        {
            Console.WriteLine("Testing Unorderd List");
            IList<int> u = new UnorderedArrayList<int>();
            testIntData(u);

            Console.WriteLine("");
            Console.WriteLine("Testing Sorted Unorderd List");
            u.Sort().Print();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Testing Orderd List");
            u = new OrderedLinkedList<int>();
            testIntData(u);
        }

        private static void testIntData(IList<int> u) { 
            int var = 5;
            u.Insert(var);
            u.Insert(var);
            var = 12;
            u.Insert(var);
            var = 2;
            u.Insert(var);
            var = 29;
            u.Insert(var);
            u.Insert(5);
            u.Print();

            Console.WriteLine("");
            Console.WriteLine(u.Min());
            Console.WriteLine(u.Max());

            Console.WriteLine("");

            var = 2;
            u.Remove(var);
            u.Print();

            Console.WriteLine("");
            u.Insert(2);
            u.RemoveAll(29);
            u.Print();

            Console.WriteLine("");
            Console.WriteLine(u.Min());
            Console.WriteLine(u.Max());
        }

        private static void testDouble()
        {
            Console.WriteLine("Testing Unorderd List");
            IList<double> u = new UnorderedArrayList<double>();
            testDoubleData(u);

            Console.WriteLine("");
            Console.WriteLine("Testing Sorted Unorderd List");
            u.Sort().Print();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Testing Orderd List");
            u = new OrderedLinkedList<double>();
            testDoubleData(u);
        }

        private static void testDoubleData(IList<double> u)
        {
            double var = 5.0;
            u.Insert(var);
            u.Insert(var);
            var = 12.6;
            u.Insert(var);
            var = 2.5;
            u.Insert(var);
            u.Insert(var);
            var = 29.7;
            u.Insert(var);
            u.Insert(5.0);
            u.Print();

            Console.WriteLine("");
            Console.WriteLine(u.Min());
            Console.WriteLine(u.Max());

            Console.WriteLine("");

            var = 2.5;
            u.Remove(var);
            u.Print();

            Console.WriteLine("");
            u.Insert(2.5);
            u.RemoveAll(29.7);
            u.Print();

            Console.WriteLine("");
            Console.WriteLine(u.Min());
            Console.WriteLine(u.Max());
        }

        private static void testString()
        {
            Console.WriteLine("Testing Unorderd List");
            IList<string> u = new UnorderedArrayList<string>();
            testStringData(u);

            Console.WriteLine("");
            Console.WriteLine("Testing Sorted Unorderd List");
            u.Sort().Print();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Testing Orderd List");
            u = new OrderedLinkedList<string>();
            testStringData(u);
        }

        private static void testStringData(IList<string> u)
        {
            u.Print();

            string var = "abcd";
            u.Insert(var);
            u.Insert(var);
            var = "efgh";
            u.Insert(var);
            var = "tgbc";
            u.Insert(var);
            var = "hello";
            u.Insert(var);
            u.Print();

            Console.WriteLine("");
            Console.WriteLine(u.Min());
            Console.WriteLine(u.Max());

            var = "abcd";
            u.Remove(var);
            u.Print();

            Console.WriteLine("");
            Console.WriteLine(u.Min());
            Console.WriteLine(u.Max());
        }
    }
}
