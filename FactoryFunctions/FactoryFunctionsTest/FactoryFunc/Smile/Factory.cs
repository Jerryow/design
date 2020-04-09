using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunc.Smile
{
    public class Factory
    {
        public enum SmileType
        { 
            People,
            Robot,
            Animals
        }

        public static IBase CreateInstance(SmileType smileType)
        {
            switch (smileType)
            {
                case SmileType.Robot:
                    return new Robot();
                case SmileType.People:
                    return new People();
                case SmileType.Animals:
                    return new Animals();
                default:
                    return new Robot();
            }
        }
    }
}
