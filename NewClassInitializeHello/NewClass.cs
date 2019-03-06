using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassInitializeHello
{
    class NewClass
    {
        public NewClass(string[] args)
        {
            if(args.Length>=2)
            Console.WriteLine("Hello World I'm {0} {1}",args[0],args[1]);
            else if(args.Length==1) Console.WriteLine("Hello World I'm {0} ",args[0]);
            else Console.WriteLine("Hello World !");
        }
    }
}
