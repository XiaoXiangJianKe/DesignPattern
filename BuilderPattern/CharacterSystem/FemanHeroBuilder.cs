using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CharacterSystem
{
    class FemanHeroBuilder : CharacterBuilder
    {
        private Character character = new Character();

        public override void BuilderId()
        {
            character.Id = 20001;
        }

        public override void BuilderName()
        {
            character.Name = "貂蝉";
        }

        public override void BuilderType()
        {
            character.Type = "舞姬";
        }

        public override void BuilderSex()
        {
            character.Sex = "女";
        }

        public override Character GetCharacter()
        {
            return character;
        }
    }
}
