using FactoryFunc.Smile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.FactoryFun
{
    public class RobotFactory
    {
        public IBase CreateInstance()
        {
            IBase people = new Robot();
            return people;
        }
    }
}
