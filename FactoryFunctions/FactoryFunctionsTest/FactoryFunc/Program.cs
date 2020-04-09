using FactoryFunc.Smile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryFunc;

namespace FactoryFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //对象创建不依赖细节 但是工厂的职责太多 集中了太多的对象创建
                IBase a = Factory.CreateInstance(Factory.SmileType.Animals);
                a.Smile();
                IBase b = Factory.CreateInstance(Factory.SmileType.People);
                b.Smile();
                IBase c = Factory.CreateInstance(Factory.SmileType.Robot);
                c.Smile();
            }

            {
                //易于扩展 全部交给单一的工厂  但是实例化对象很麻烦
                FactoryFun.AnimalsFactory animalsFactory = new FactoryFun.AnimalsFactory();
                IBase animals = animalsFactory.CreateInstance();

                FactoryFun.PeopleFactory peopleFactory = new FactoryFun.PeopleFactory();
                IBase people = peopleFactory.CreateInstance();
                people.Smile();

                FactoryFun.RobotFactory robotFactory = new FactoryFun.RobotFactory();
                IBase robot = robotFactory.CreateInstance();

                //可以使用虚方法来进行扩展
                FactoryFun.BaseFactory baseFactory = new FactoryFun.FactoryExtend();
                IBase peopleTwo = baseFactory.CreateInstance();
                peopleTwo.Smile();
            }


            Console.ReadKey();
        }
    }
}
