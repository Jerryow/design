using FactoryFunc.Smile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.FactoryFun
{
    public class BaseFactory
    {
        public virtual IBase CreateInstance()
        {
            IBase animals = new Animals();
            return animals;
        }
    }
}
