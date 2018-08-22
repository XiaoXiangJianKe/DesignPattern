using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.FSM
{
    abstract class StateMachine
    {
        protected char word; 
        protected State currentState;
        protected List<State> stateList = new List<State>();

        public Char Word { get { return word; } set { word = value; } }
        public State CurrentState { get { return currentState; } set { currentState = value; } }

        public abstract void AddState(State state);
        public abstract void RemoveState(State state);
    }
}
