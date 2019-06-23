using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.Strategy = new StrategyA();
            context.Algorithm();

            context.Strategy = new StrategyB();
            context.Algorithm();
        }
    }
}
