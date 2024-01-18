using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            If_Else if_else = new If_Else();
            if_else.Perform();

            Loops loops = new Loops();
            loops.ForLoop();
            loops.WhileLoop();
            loops.DoWhileLoop();
            loops.ForEachLoop();

            ExceptionHandling eh = new ExceptionHandling();
            eh.Perform();
            */

            DifferentCollections dc = new DifferentCollections();
            dc.PerformList();
            dc.PerformDictionary();
            dc.PerformHashSet();
            dc.PerformStack();
            dc.PerformQueue();
        }
    }
}
