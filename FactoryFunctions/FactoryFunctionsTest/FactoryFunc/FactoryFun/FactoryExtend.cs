using FactoryFunc.Smile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.FactoryFun
{
    public class FactoryExtend : BaseFactory
    {
        public override IBase CreateInstance()
        {
            //return base.CreateInstance();//使用原始方法
            IBase peple = new People();
            return peple;
        }
    }
}
