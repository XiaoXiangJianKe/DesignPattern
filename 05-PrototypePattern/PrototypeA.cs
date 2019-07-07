using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class PrototypeA : Prototype
    {
        public PrototypeA(string id)
            : base(id)
        {

        }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }
}
