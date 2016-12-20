using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var policy = new Policy();
            var insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
