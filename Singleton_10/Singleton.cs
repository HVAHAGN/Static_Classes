using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_10
{ //Singleton
    class Singleton
    {
        private static Singleton instance = null;
        //Constructor protected
        protected Singleton()
        {

        }
        //Factory method
        public static Singleton Instance()
        { //if instance not created
            if(instance==null)

            {//then create an instance
                instance = new Singleton();
            }
            //else return link an existing instance
            return instance;
        }

    }
}
