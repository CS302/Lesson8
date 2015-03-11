using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    public class Disk : Good
    {
        private string name;
        public Disk(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Print()
        {
            Console.WriteLine("Диск - {0}  ({1})", name, weight);
        }
    }
}
