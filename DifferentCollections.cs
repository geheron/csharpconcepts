using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpConcepts
{
    class DifferentCollections
    {
        public void PerformList()
        {
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Ball");
            list.Add("Cat");
            list.Add("Dog");
            list.Remove("Elephant");
            list.Remove("Ball");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Count of items in list is: {list.Count}");
        }

        public void PerformDictionary()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("name", 1);
            dictionary.Add("rollno", 2);
            dictionary.Add("address", 3);
            /*
            try
            {
                dictionary.Add("address", 3);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            dictionary.Remove("rollno");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }

        public void PerformHashSet()
        {

            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("book");
            hashset.Add("pen");
            hashset.Add("ruler");
            hashset.Add("pencil");
            hashset.Add("pencil");
            hashset.Remove("pen");

            Console.WriteLine("Hashset");
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }

            HashSet<string> h2 = new HashSet<string>();
            h2.Add("Teacher");
            h2.Add("Student");

            hashset.UnionWith(h2);
            Console.WriteLine("Hashset after union");
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }

        public void PerformStack()
        {
            Console.WriteLine("Performing stack");
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            try
            {
                Console.WriteLine($"Top of stack: {st.Peek()}");
                Console.WriteLine(st.Pop());
                Console.WriteLine(st.Pop());
                Console.WriteLine(st.Pop());
                Console.WriteLine(st.Pop());
                Console.WriteLine(st.Pop());
                //Console.WriteLine(st.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(st.Count());
        }

        public void PerformQueue()
        {
            Console.WriteLine("Performing queue");
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            try
            {
                Console.WriteLine($"Front of queue: {q.Peek()}");
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(q.Count());
        }
    }
}
