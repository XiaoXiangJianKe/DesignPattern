using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.FSM
{
    class Idle : State
    {
        public override void OnEnter()
        {
           Console.WriteLine("进入Idle状态");
        }

        public override void OnStay()
        {
            Console.WriteLine("保持Idle状态");
            foreach(Transition transition in transitionList)
            {
                if(transition.OnCheck(stateMachine))
                {
                    DoTransition(transition);
                }
            }
        }

        public override void OnExit()
        {
            Console.WriteLine("离开Idle状态");
        }

        public override void AddTransition(Transition transition)
        {
            if(!transitionList.Contains(transition))
            {
                transitionList.Add(transition);
            }
        }

        public override void RemoveTransition(Transition transition)
        {
            if (transitionList.Contains(transition))
            {
                transitionList.Remove(transition);
            }
        }

        public override void DoTransition(Transition transition)
        {
            stateMachine.CurrentState.OnExit();
            stateMachine.CurrentState = transition.ToState;
            stateMachine.CurrentState.OnEnter();
        }
    }
}
