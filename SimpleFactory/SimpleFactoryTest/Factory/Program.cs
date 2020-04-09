using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    //要抽象,不要细节
    class Program
    {
        static void Main(string[] args)
        {
            {
                //对象创建依赖细节
                IBase a = new People();
                a.Smile();
                IBase b = new Animals();
                b.Smile();
                IBase c = new Robot();
                c.Smile();
            }

            {
                //对象创建不依赖细节
                IBase a = SmileFactory.CreateInstance(SmileFactory.SmileType.Animals);
                a.Smile();
                IBase b = SmileFactory.CreateInstance(SmileFactory.SmileType.People);
                b.Smile();
                IBase c = SmileFactory.CreateInstance(SmileFactory.SmileType.Robot);
                c.Smile();
            }
            Console.ReadKey();
        }
    }
}
