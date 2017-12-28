using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbagePracktice
{
    class Program
    {
        static void Main(string[] args)
        {
            Temp temp = new Temp("I", 1);

            Console.WriteLine("Current generation: {0}", GC.GetGeneration(temp));
            Console.ReadKey();
            GC.Collect();
            Console.WriteLine("Generation changed!");
            Console.WriteLine("Current generation: {0}", GC.GetGeneration(temp));

            Console.ReadLine();
        }
    }
}
