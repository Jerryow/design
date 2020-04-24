using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Observers
{
    public class LittleBrother 
    {

        public void TakeContainer()
        {
            Console.WriteLine($"{0} 拿水壶....", this.GetType().Name);
        }

    }
}
