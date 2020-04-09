using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //单线程-非单例
                for (int i = 0; i < 10; i++)
                {
                    Func func = new Func();
                    func.Show();
                }

                //单线程-单例
                for (int i = 0; i < 10; i++)
                {
                    SingleFunc single = SingleFunc.CreateObject();
                    single.Show();
                }
            }

            {
                //多线程-单例
                for (int i = 0; i < 10; i++)
                {
                    new Action(() =>
                    {
                        SingleFunc single = SingleFunc.CreateObject();
                        single.Show();
                    }).BeginInvoke(null,null) ;
                }
            }

            Console.ReadKey();
        }
    }
}
