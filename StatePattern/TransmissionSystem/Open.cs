using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TransmissionSystem
{
    class Open : GateState
    {
        public override void Click(TransmissionGate transGate)
        {
            transGate.GateState = new StayOpen();
            Console.WriteLine(string.Format("当前状态为：{0}", transGate.GateState.GetType().ToString()));
        }

        public override void Complete(TransmissionGate transGate)
        {
            Console.WriteLine(string.Format("当前状态为：{0}, 无法触发Complete事件！", transGate.GateState.GetType().ToString()));
        }

        public override void TimeOut(TransmissionGate transGate)
        {
            transGate.GateState = new Closing();
            Console.WriteLine(string.Format("当前状态为：{0}", transGate.GateState.GetType().ToString()));
        }
    }
}
