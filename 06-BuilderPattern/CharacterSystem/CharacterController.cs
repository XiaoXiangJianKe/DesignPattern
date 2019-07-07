using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CharacterSystem
{
    class CharacterController
    {
        public void Construct(CharacterBuilder characterBuilder)
        {
            characterBuilder.BuilderId();
            characterBuilder.BuilderName();
            characterBuilder.BuilderSex();
            characterBuilder.BuilderType();
        }
    }
}
