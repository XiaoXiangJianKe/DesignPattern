using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TransmissionSystem
{
    class TransmissionGate
    {
        private GateState gateState;

        public GateState GateState { get { return gateState; } set { gateState = value; } }

        public TransmissionGate(GateState gateState)
        {
            this.gateState = gateState;
        }

        public void Click()
        {
            gateState.Click(this);
        }
        public void Complete()
        {
            gateState.Complete(this);
        }

        public void TimeOut()
        {
            gateState.TimeOut(this);
        }
    }
}
