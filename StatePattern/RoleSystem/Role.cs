using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.RoleSystem
{
    class Role
    {
        private bool isVictory;
        private float score;
        private Level level;

        public bool IsVictory { get { return isVictory; } set { isVictory = value; } }
        public float Score { get { return score; } set { score = value; } }
        public Level Level { get { return level; } set { level = value; } }

        public Role(Level level, float score)
        {
            this.level = level;
            this.score = score;
        }

        public void Play()
        {
            level.Play(this);
        }
    }
}
