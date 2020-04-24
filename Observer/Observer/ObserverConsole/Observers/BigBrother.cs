using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Observers
{
    public class BigBrother 
    {

        public void CloseElec()
        {
            Console.WriteLine($"{0} 关闭电源....", this.GetType().Name);
        }

    }
}
