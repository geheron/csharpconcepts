using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpConcepts
{
    class Loops
    {
        public void ForLoop()
        {
            Console.WriteLine("This is For Loop");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"This is number {i}");
            }
        }

        public void WhileLoop()
        {
            Console.WriteLine("This is While Loop");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"This is number {i}");
                i++;
            }
        }

        public void DoWhileLoop()
        {
            Console.WriteLine("This is Do While Loop");
            int i = 1;
            do
            {
                Console.WriteLine($"This is number {i}");
                i++;
            }
            while (i <= 5);
        }

        public void ForEachLoop()
        {
            Console.WriteLine("This is Foreach Loop");
            Console.Write("Enter size of array: ");
            int size;
            int[] arr;
            try
            {
                size = Convert.ToInt32(Console.ReadLine());
                arr = new int[size];
                try
                {
                    Console.WriteLine("Enter values:");
                    for (int i = 0; i < size; i++)
                    {
                        int num = Convert.ToInt32(Console.ReadLine());
                        arr[i] = num;
                    }
                    Console.WriteLine("Printing the array: ");
                    foreach (int number in arr)
                    {
                        Console.WriteLine(number);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
