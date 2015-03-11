using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    public abstract class Good
    {
        protected int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public abstract void Print();
    }
}
