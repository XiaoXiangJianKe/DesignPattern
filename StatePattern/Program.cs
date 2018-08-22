using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.RoleSystem;
using StatePattern.TransmissionSystem;
using StatePattern.FSM;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("状态模式");
            #region 角色系统
            //Role role = new Role(new Primary(), 0.0f);
            //role.IsVictory = true;
            //role.Play();
            //role.IsVictory = true;
            //role.Play();
            //role.IsVictory = true;
            //role.Play();
            //role.IsVictory = true;
            //role.Play();
            //role.IsVictory = true;
            //role.Play();
            //role.IsVictory = true;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();
            //role.IsVictory = false;
            //role.Play();            
            #endregion

            #region 传输门
            //TransmissionGate transGate = new TransmissionGate(new Closed());
            //transGate.Complete();
            //transGate.Click();
            //transGate.TimeOut();
            //transGate.Click();
            //transGate.Complete();
            //transGate.TimeOut();
            //transGate.Click();
            //transGate.Complete();
            //transGate.TimeOut();
            //transGate.Click();
            //transGate.Complete();
            //transGate.Click();
            //transGate.Click();
            //transGate.Complete();           
            #endregion

            Idle idle = new Idle();
            Walk walk = new Walk();
            Jump jump = new Jump();
            Attack attack = new Attack();

            idle.AddTransition(new JyTransition(idle, walk, 'w'));
            idle.AddTransition(new JyTransition(idle, jump, 'j'));
            idle.AddTransition(new JyTransition(idle, attack, 'k'));

            walk.AddTransition(new JyTransition(walk, idle, 's'));
            walk.AddTransition(new JyTransition(walk, jump, 'j'));
            walk.AddTransition(new JyTransition(walk, attack, 'k'));

            jump.AddTransition(new JyTransition(jump, idle, 's'));
            jump.AddTransition(new JyTransition(jump, walk, 'w'));
            jump.AddTransition(new JyTransition(jump, attack, 'k'));

            attack.AddTransition(new JyTransition(attack, idle, 's'));
            attack.AddTransition(new JyTransition(attack, walk, 'w'));
            attack.AddTransition(new JyTransition(attack, jump, 'j'));

            HeroStateMachine heroStateMachine = new HeroStateMachine(idle);
            heroStateMachine.AddState(walk);
            heroStateMachine.AddState(jump);
            heroStateMachine.AddState(attack);

            ConsoleKeyInfo ConsoleKeyInfo = new ConsoleKeyInfo();
            while (ConsoleKeyInfo.Key != ConsoleKey.Escape)
            {
                ConsoleKeyInfo = Console.ReadKey();
                Console.WriteLine(ConsoleKeyInfo.Key.ToString());
                heroStateMachine.Word = ConsoleKeyInfo.KeyChar;
                heroStateMachine.OnStay();
            }
        }
    }
}
