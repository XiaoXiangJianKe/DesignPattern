using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StateB : State
    {
        public override void Handler(Context context)
        {
            context.State = new StateA();
        }
    }
}
