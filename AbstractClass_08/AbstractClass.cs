using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_08
{
    abstract class AbstractClass
    {
        //Static factory method
       public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }
        public abstract void Method();
    }
}
