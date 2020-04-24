using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverConsole.Pulisher;
using ObserverConsole.Observers;

namespace ObserverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先定义一下场景
            //1.只有一个初始的事情----->水烧开了
            //2.在水烧开之后---->
            //   2.1--->哥哥去关电源
            //   2.2--->姐姐去拿水杯
            //   2.3--->弟弟去拿水壶

            //哥哥.姐姐.弟弟作为观察者---->水烧开了之后相应的做出动作

            //方式1
            //事件驱动---->观察者模式   可以+=   可以-=

            //方式2 --> 这个就不写了....
            //1.定义一个接口
            //2.哥哥、姐姐、弟弟 继承此接口并且实现的方法调用实际动作方法
            //3.主对象(water)维护一个抽象的list
            //4.主对象的方法执行之后循环遍历维护的list里面的对象的方法


            Water water = new Water();

            //事件注册
            water.FirstAction += new BigBrother().CloseElec;
            water.FirstAction += new LittleBrother().TakeContainer;
            water.FirstAction += new Sister().TakeCup;

            water.WaterOK();

            Console.ReadKey();
        }
    }
}
