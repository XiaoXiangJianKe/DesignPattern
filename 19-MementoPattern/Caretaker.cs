using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 管理员
    /// </summary>
    class Caretaker
    {
        private Memento memento;

        public Memento Memento { get { return memento; } set { memento = value; } }
    }
}
