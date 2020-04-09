using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Robot : IBase
    {
        public void Smile()
        {
            Console.WriteLine("{0}：Smile",this.GetType().Name);
        }
    }
}
