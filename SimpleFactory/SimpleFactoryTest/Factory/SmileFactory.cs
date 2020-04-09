using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SmileFactory
    {
        //简单工厂违背了职责单一原则
        public enum SmileType
        { 
            Robot,
            People,
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
