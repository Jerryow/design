using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Single
{

    /// <summary>
    /// 不单例
    /// </summary>
    public class Func
    {
        /// <summary>
        /// 场景,当对象的创建耗时且好资源
        /// </summary>
        public Func()
        {
            Thread.Sleep(3000);
            Console.WriteLine("被构造一次");
        }

        /// <summary>
        /// 提供方法
        /// </summary>
        public void Show()
        {
            Console.WriteLine("非单例Show.");
        }
    }

    /// <summary>
    /// 单例--防止对象重复创建耗时耗性能
    /// </summary>
    public class SingleFunc
    {
        private static SingleFunc single = null;
        private static object lockObj = new object();//防止多线程抢占资源会构造多次
        /// <summary>
        /// 场景,当对象的创建耗时且好资源
        /// </summary>
        private SingleFunc()
        {
            Thread.Sleep(3000);
            Console.WriteLine("单例被构造一次");
        }


        public static SingleFunc CreateObject()
        {
            if (single == null)//防止多线程等待锁
            {
                lock (lockObj)
                {
                    //假如此时有耗时功能,最外层判断可以防止多线程等锁
                    //Thread.Sleep(1000);
                    if (single == null)
                    {
                        single = new SingleFunc();
                    }
                }
            }
            return single;
        }

        /// <summary>
        /// 提供方法
        /// </summary>
        public void Show()
        {
            Console.WriteLine("非单例Show.");
        }
    }

}
