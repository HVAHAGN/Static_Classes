using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_04
{
    class NotStaticClass
    {
        //static field default private
        static int field;

        //static property Field
        //from static members cant call not static member

        public static int Field
        {
            get { return field; }
            set { field = value; }



        }
    }
}
