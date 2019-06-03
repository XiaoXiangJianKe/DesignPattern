using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BuilderB : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part X");
        }

        public override void BuildPartB()
        {
            product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
