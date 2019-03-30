using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_04
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass.Field = 33;
            Console.WriteLine(NotStaticClass.Field);
            Console.ReadLine();
        }
    }
}
