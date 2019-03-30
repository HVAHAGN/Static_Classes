using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Protected constructor cant used
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if(instance1==instance2)
            {
                Console.WriteLine("Referenced to the same instance");
            }
            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance1.GetHashCode());

            Console.ReadLine();
        }
    }
}
