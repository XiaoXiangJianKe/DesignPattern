using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 环境类
    /// </summary>
    class Context
    {
        private State state;

        public State State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                Console.WriteLine("State：" + state.GetType().Name);
            }
        }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            state.Handler(this);
        }
    }
}
