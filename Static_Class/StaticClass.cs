using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    // Static class in C #, expresses the idea of ​​a design pattern - Singleton.

    // Rules:
    // 1. An instance of a static class cannot be created.
    // 2. The static class is always inherited from Оbject (Attempting to inherit from something else results in a compilation error).
    // 3. Static class does not implement interfaces. Attempting to inherit from an interface results in a compilation level error.
    // 4. Contains only static members (the presence of a non-static member will lead to a compilation error).
    // 5. A static class cannot contain instance constructors.
    // 6. The static class is closed for inheritance from it. Attempting to inherit from a static class results in a compilation level error.Default sealed
    static class StaticClass//: object // Inherit only from Object (explicitly or implicitly)
    {
        // // The instance constructor is invalid.
        // public StaticClass()
        // {
        //     Console.WriteLine("Constructor");
        // }
        static StaticClass()
        {
            Console.WriteLine("Constructor");
        }

        //static method
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        //not static member
        //public void NotStaticMethod()
        //{
        //    Console.WriteLine("NotStatic");
        //}


    }
}
