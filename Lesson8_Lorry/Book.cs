using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    public class Book : Good
    {
        private string name;
        public Book(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Print()
        {
            Console.WriteLine("Книга - {0}  ({1})", name, weight);
        }
    }
}
