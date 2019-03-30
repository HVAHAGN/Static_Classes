using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    class NotStaticClass
    {
        private int Id;
        public static int field;

        public NotStaticClass(int id)
        {
            this.Id = id;

        }
        public void Method()
        {
            // We can call from not static method a static member of class 
            Console.WriteLine("Instance {0}.field={1}", Id, field);
        }

    }
}
