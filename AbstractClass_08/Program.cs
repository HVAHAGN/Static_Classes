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
            //abstract class can contain static member
            AbstractClass instance = AbstractClass.CreateObject();
            
            // call not static method 
            instance.Method();

            Console.ReadLine();
        }
    }
}
