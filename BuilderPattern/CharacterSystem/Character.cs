using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CharacterSystem
{
    class Character
    {
        private int id;
        private string name;
        private string type;
        private string sex;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string Sex { get { return sex; } set { sex = value; } }

        public void Show()
        {
            Console.WriteLine("");
            Console.WriteLine("编号：" + id);
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("类型：" + type);
            Console.WriteLine("性别：" + sex);
        }
    }
}
