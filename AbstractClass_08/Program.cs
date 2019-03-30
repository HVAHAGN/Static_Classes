using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_08
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

            Console.ReadLine();
        }
    }
}
