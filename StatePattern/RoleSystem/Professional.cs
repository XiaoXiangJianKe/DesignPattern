using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.RoleSystem
{
    /// <summary>
    /// 高手级
    /// </summary>
    class Professional : Level
    {
        public override void Play(Role role)
        {
            if (role.IsVictory)
            {
                role.Score += 50.0f * DoubleScore();
            }
            else
            {
                role.Score -= 50.0f;
                if (role.Score < 0.0f)
                    role.Score = 0.0f;
            }

            if (role.Score <= 200)
            {
                role.Level = new Secondary();
            }
            else if (role.Score > 400)
            {
                role.Level = new Final();
            }

            Console.WriteLine(string.Format("当前分数为：{0}, 当前等级为：{1}", role.Score, role.Level.GetType().ToString()));
        }

        public override int DoubleScore()
        {
            return 2;
        }

        public override void ChangeCards()
        {
            Console.WriteLine("换牌！");
        }

        public override void PeekCards()
        {
            Console.WriteLine("没有看牌功能！");
        }
    }
}
