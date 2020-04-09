using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.LetSmile
{
    public class Smiler
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void LetSomeoneSmile(Smile.IBase who)
        {
            who.Smile();
        }
    }
}
