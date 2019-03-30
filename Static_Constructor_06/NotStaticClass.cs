using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_06
{
    class NotStaticClass
    {// Static constructor.

        // Static constructors have the following properties:
        // 1. The static constructor has no access modifiers and does not accept parameters.
        // 2. The static constructor is called automatically to initialize the class before creating the first instance.
        // or by reference to any static members.
        // 3. The static constructor cannot be called directly.
        // 4. The user does not control when the static constructor is executed in the program.
        // 5. A typical use of static constructors is when a class uses a log file and
        // constructor is used to add entries to this file.

        // The readonly static fields should be initialized in the constructor.
        static readonly long readonlyField = 2;
        //Static Property readonly
        public static long ReadonlyField
        {
            get { return NotStaticClass.readonlyField; }
        }
        //Static Constructor
        static NotStaticClass()
        {
            Console.WriteLine("Static Constructor");
            readonlyField = 7;
        }
      


      
    }
}

