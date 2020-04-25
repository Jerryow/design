using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorConsole
{
    public class DoSomething :IDoSomething
    {
        public void Do()
        {
            Console.WriteLine("这里是我最初的动作......");
        }
    }
}
