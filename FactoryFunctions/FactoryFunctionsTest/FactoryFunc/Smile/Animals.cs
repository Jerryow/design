using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.Smile
{
    public class Animals : IBase
    {
        public void Smile()
        {
            Console.WriteLine("{0}:Smile", this.GetType().Name);
        }
    }
}
