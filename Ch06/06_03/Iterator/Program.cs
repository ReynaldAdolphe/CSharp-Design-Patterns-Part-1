using Iterator.Aggregate;
using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyp = new NYPaper();
            INewspaper lap = new LAPaper();

            IIterator nypIterator = nyp.CreateIterator();
            IIterator lapIterator = lap.CreateIterator();

            Console.WriteLine("--------   NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator) {
            iterator.First();
            while(!iterator.IsDone()){
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
