using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_02
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance = new NotStaticClass(1);
            NotStaticClass.Method();

            Console.ReadLine();
        }
    }
}
