using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.RoleSystem;
using StatePattern.TransmissionSystem;

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

            TransmissionGate transGate = new TransmissionGate(new Closed());
            transGate.Complete();
            transGate.Click();
            transGate.TimeOut();
            transGate.Click();
            transGate.Complete();
            transGate.TimeOut();
            transGate.Click();
            transGate.Complete();
            transGate.TimeOut();
            transGate.Click();
            transGate.Complete();
            transGate.Click();
            transGate.Click();
            transGate.Complete();
        }
    }
}
