using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TransmissionSystem
{
    abstract class GateState
    {
        public abstract void Click(TransmissionGate transGate);
        public abstract void Complete(TransmissionGate transGate);
        public abstract void TimeOut(TransmissionGate transGate);
    }
}
