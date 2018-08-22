using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.FSM
{
    class JyTransition : Transition
    {
        public JyTransition(State fromState, State toState, Char word)
        {
            this.fromState = fromState;
            this.toState = toState;
            this.word = word;
        }

        public override bool OnCheck(StateMachine stateMachine)
        {
            return stateMachine.Word == word;
        }
    }
}
