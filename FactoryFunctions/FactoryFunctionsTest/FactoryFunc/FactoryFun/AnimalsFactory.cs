using FactoryFunc.Smile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.FactoryFun
{
    public class AnimalsFactory
    {
        public IBase CreateInstance()
        {
            IBase people = new Animals();
            return people;
        }
    }
}
