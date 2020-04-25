using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorConsole
{
    class Program
    {
        //装饰器模式---->
        //功能就是:
        //在不破坏原有对象的功能情况下  动态的给这个对象装饰(增加)一点东西--->或者动作
        static void Main(string[] args)
        {
            //背景介绍:
            //IDoSomething 和DoSomething 是我最开始需要做的动作

            {
                //这里我只能执行Do里面的逻辑，如果要增加逻辑需要改Do里面的内容
                IDoSomething doSomething = new DoSomething();
                doSomething.Do();
            }

            {
                //这里我想不改Do里面的内容去增加逻辑--->其实静态代理也可以完成....但是这里说的是装饰器模式
                IDoSomething doSomething = new DoSomething();
                IDoSomething doSomethingDecorator = new DecoratorDoSomething(doSomething);
                doSomethingDecorator.Do();
            }


            Console.Read();
        }
    }
}
