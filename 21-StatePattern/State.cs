using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 抽象状态类
    /// </summary>
    abstract class State
    {
        public abstract void Handler(Context context);
    }
}
