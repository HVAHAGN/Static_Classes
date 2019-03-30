using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_05
{
    class NotStaticClass
    {

        // If the class contains static fields, a static constructor should be provided,
        // which initializes these fields when loading the class.
        private static int field;
        public static int Field
        {
            get { return field; }
            set { field = value; }
        }

        // Static constructor.
        // The only purpose of static constructors is to assign initial values to static variables.
        //only default constructo cant be custom
        static NotStaticClass()
        {
            Console.WriteLine("Static constructor");
            field = 1;
        }

        // Static methods can be overloaded.
        public static void Method()
        {
            Console.WriteLine("static method of not static class");
        }
        // Static methods can be overloaded.
        public static void Method(int s)
        {
            Console.WriteLine("Overloaded static method "+s);
        }

        //Not static method
        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
        public NotStaticClass()
        {
            Console.WriteLine("Not static constructor");
        }
    }
}

