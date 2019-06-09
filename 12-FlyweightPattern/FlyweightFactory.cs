using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class FlyweightFactory
    {
        private Dictionary<string, Flyweight> dicFlyweight = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string key)
        {
            Flyweight flyweight;
            if(dicFlyweight.ContainsKey(key))
            {
                flyweight = dicFlyweight[key];
            }
            else
            {
                flyweight = new ConcreteFlyweight();
                dicFlyweight.Add(key, flyweight);
            }
            return flyweight;
        }
    }
}
