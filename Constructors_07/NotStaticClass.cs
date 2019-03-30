using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_07
{
    class NotStaticClass
    {
        // Instance constructor, called only when creating an instance of a class.
        public NotStaticClass()
        {
            Console.WriteLine("Constructor.");
        }

        // The static constructor is called anyway
        // as when referring to a static member, and when creating an instance of the class.

        static NotStaticClass()
        {
            Console.WriteLine("Static constructor");
        }
            
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
            //Not static method
        public void NotStaticMethod()
        {
            Console.WriteLine("Notstatic method");
        }
        
    }
}

