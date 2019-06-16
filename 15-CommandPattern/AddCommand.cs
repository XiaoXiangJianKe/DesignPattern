using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class AddCommand : Command
    {
        public AddCommand(Receiver receiver)
            : base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.Add();
        }
    }
}
