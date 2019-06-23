using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.RoleSystem
{
    /// <summary>
    /// 熟练级
    /// </summary>
    class Secondary : Level
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

            if (role.Score <= 100)
            {
                role.Level = new Primary();
            }
            else if (role.Score > 200)
            {
                role.Level = new Professional();
            }

            Console.WriteLine(string.Format("当前分数为：{0}, 当前等级为：{1}", role.Score, role.Level.GetType().ToString()));
        }

        public override int DoubleScore()
        {
            return 2;
        }

        public override void ChangeCards()
        {
            Console.WriteLine("没有换牌功能！");
        }

        public override void PeekCards()
        {
            Console.WriteLine("没有看牌功能！");
        }
    }
}
