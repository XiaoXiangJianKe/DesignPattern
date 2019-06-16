using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class RemoveCommand : Command
    {
        public RemoveCommand(Receiver receiver)
            : base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.Remove();
        }
    }
}
