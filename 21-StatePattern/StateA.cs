using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StateA : State
    {
        public override void Handler(Context context)
        {
            context.State = new StateB();
        }
    }
}
