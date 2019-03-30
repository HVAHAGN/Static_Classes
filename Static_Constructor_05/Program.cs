
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_05
{
    class Program
    {
        static void Main(string[] args)
        {

            NotStaticClass instance = new NotStaticClass();
            instance.NotStaticMethod();
            NotStaticClass.Field = 7;

            NotStaticClass.Method();
            NotStaticClass.Method(88);

            Console.ReadLine();
        }
    }
}
