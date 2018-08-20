using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.RoleSystem;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("状态模式");
            Role role = new Role(new Primary(), 0.0f);
            role.IsVictory = true;
            role.Play();
            role.IsVictory = true;
            role.Play();
            role.IsVictory = true;
            role.Play();
            role.IsVictory = true;
            role.Play();
            role.IsVictory = true;
            role.Play();
            role.IsVictory = true;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
            role.IsVictory = false;
            role.Play();
        }
    }
}
