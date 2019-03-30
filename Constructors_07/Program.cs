using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Is Called only static constructor
           // NotStaticClass.StaticMethod();

            // both constructors called

            new NotStaticClass().NotStaticMethod();

            Console.ReadLine();
        }
    }
}
