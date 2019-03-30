using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_02
{
    class NotStaticClass
    {
        private int Id;
        //Constructor
        public NotStaticClass(int id)
        {
            this.Id = id;

        }
        public static void Method()
        {
           // Console.WriteLine("Instance.Id={0}", Id);
            
            Console.WriteLine("We cant call not static member from static method ");
        }

    }
}
