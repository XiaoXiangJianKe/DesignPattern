using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CharacterSystem
{
    class ManHeroBuilder : CharacterBuilder
    {
        private Character character = new Character();

        public override void BuilderId()
        {
            character.Id = 10001;
        }

        public override void BuilderName()
        {
            character.Name = "吕布";
        }

        public override void BuilderType()
        {
            character.Type = "战士";
        }

        public override void BuilderSex()
        {
            character.Sex = "男";
        }

        public override Character GetCharacter()
        {
            return character;
        }
    }
}
