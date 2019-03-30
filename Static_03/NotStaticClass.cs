using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_03
{
    class NotStaticClass
    {
        //Constant cant be static because it's behavior is already static
        //public static const float e = 2.174586987896;
        // field const relates to type not an instance
        // you can call const field as static member of class
        public const float e = 2.17545869874333f;


    }
}
