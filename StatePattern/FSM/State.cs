using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.FSM
{
    abstract class State
    {
        protected StateMachine stateMachine;
        protected List<Transition> transitionList = new List<Transition>();

        public StateMachine StateMachine { get { return stateMachine; } set { stateMachine = value; } }

        public abstract void OnEnter();
        public abstract void OnStay();
        public abstract void OnExit();
        public abstract void AddTransition(Transition transition);
        public abstract void RemoveTransition(Transition transition);
        public abstract void DoTransition(Transition transition);
    }
}
