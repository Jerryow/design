using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Observers
{
    public class Sister
    {

        public void TakeCup()
        {
            Console.WriteLine($"{0} 拿水杯....", this.GetType().Name);
        }

    }
}
