using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.RoleSystem
{
    abstract class Level
    {
        public abstract void Play(Role role);
        public abstract int DoubleScore();
        public abstract void ChangeCards();
        public abstract void PeekCards();
    }
}
