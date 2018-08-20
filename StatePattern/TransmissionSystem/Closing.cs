using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TransmissionSystem
{
    class Closing : GateState
    {
        public override void Click(TransmissionGate transGate)
        {
            transGate.GateState = new Opening();
            Console.WriteLine(string.Format("当前状态为：{0}", transGate.GateState.GetType().ToString()));
        }

        public override void Complete(TransmissionGate transGate)
        {
            transGate.GateState = new Closed();
            Console.WriteLine(string.Format("当前状态为：{0}", transGate.GateState.GetType().ToString()));
        }

        public override void TimeOut(TransmissionGate transGate)
        {
            Console.WriteLine(string.Format("当前状态为：{0}, 无法触发TimeOut事件！", transGate.GateState.GetType().ToString()));
        }
    }
}
