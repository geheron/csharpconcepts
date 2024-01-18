using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpConcepts
{
    class If_Else
    {
        public void Perform()
        {
            Console.Write("Enter a number: ");
            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
