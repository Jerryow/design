using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorConsole
{
    public class DecoratorDoSomething : IDoSomething
    {
        private IDoSomething _doSomething { get; set; }
        public DecoratorDoSomething(IDoSomething doSomething)
        {
            this._doSomething = doSomething;
        }
        public void Do()
        {
            Console.WriteLine("增加动作前.....");
            this._doSomething.Do();
            Console.WriteLine("增加动作后.....");
        }
    }
}
