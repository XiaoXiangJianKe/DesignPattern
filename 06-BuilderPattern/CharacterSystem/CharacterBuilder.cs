using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CharacterSystem
{
    abstract class CharacterBuilder
    {
        public abstract void BuilderId();
        public abstract void BuilderName();
        public abstract void BuilderType();
        public abstract void BuilderSex();
        public abstract Character GetCharacter();
    }
}
