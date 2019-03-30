using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_09
{
    //Static members cannot be virtual, override, or abstract.

    // Static members support substitution.

    abstract class BaseClass
    {
       /* public static virtual void StaticMethod()
        {
            Console.WriteLine("BaseClass.StaticMethod");
        }*/
        public static void StaticMethod()
        {
            Console.WriteLine("BaseClass.StaticMethod");
        }
    }

    class DerivedClass : BaseClass
    {
        // public static override void StaticMethod()
        // {
        //     Console.WriteLine("static memebers cant be virtual override or abstract");
        // }

        // Static members support substitution.
        public static void StaticMethod()
        {

            Console.WriteLine("DerivedClass.StaticMethod");
        }
    }


    

    class Program
    {
        
        static void Main(string[] args)
        {
            BaseClass.StaticMethod();
            DerivedClass.StaticMethod();
            Console.ReadLine();
        }
    }
}
