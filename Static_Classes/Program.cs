using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance1 = new NotStaticClass(1);
            NotStaticClass instance2 = new NotStaticClass(2);
            instance1.Method();
            instance2.Method();

            // Notstatic class-object call
            NotStaticClass.field = 1;
            instance1.Method();
            instance2.Method();

            Console.ReadLine();
        }
    }
}
