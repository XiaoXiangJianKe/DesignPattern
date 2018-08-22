using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.FSM
{
    abstract class Transition
    {
        protected Char word;
        protected State fromState;
        protected State toState;

        public State FromState { get { return fromState; } }
        public State ToState { get { return toState; } }

        public abstract bool OnCheck(StateMachine stateMachine);
    }
}
