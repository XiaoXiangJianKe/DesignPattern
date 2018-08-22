using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.FSM
{
    class HeroStateMachine : StateMachine
    {
        public HeroStateMachine(State state)
        {
            currentState = state;
            AddState(state);
        }

        public override void AddState(State state)
        {
            if(!stateList.Contains(state))
            {
                stateList.Add(state);
                state.StateMachine = this;
            }
        }

        public override void RemoveState(State state)
        {
            if (stateList.Contains(state))
            {
                stateList.Remove(state);
            }
        }

        public void OnStay()
        {
            currentState.OnStay();
        }
    }
}
