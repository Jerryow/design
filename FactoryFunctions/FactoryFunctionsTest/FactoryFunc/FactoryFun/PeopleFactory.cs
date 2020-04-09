using FactoryFunc.Smile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.FactoryFun
{
    public class PeopleFactory
    {
        public IBase CreateInstance()
        {
            IBase people = new People();
            return people;
        }
    }
}
