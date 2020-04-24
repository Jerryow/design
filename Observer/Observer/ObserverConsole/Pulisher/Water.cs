using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Pulisher
{
    public class Water
    {

        public event Action FirstAction;//定义委托事件
        public void WaterOK()
        {
            Console.WriteLine($"{0} 烧开了....", this.GetType().Name);
            if (this.FirstAction != null)
            {
                FirstAction.Invoke();
            }
        }


    }
}
