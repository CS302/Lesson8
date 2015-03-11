using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    class Lorry
    {
        private int maxWeight;
        private List<Good> items;

        public int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Good this[int i]
        {
            get { return items[i]; }
        }

        
        private int count;
        
        public int Count
        {
            get { return items.Count; }
            set { count = value; }
        }

        public Lorry(int maWeight)
        {
            this.maxWeight = maWeight;
            items = new List<Good>();
        }

        public void Add(Good good)
        {
            if (good.Weight + Weight > maxWeight)
            {
                Console.WriteLine("Невозможно добавить товар:");
                good.Print();
                Console.WriteLine();
                return;
            }
            items.Add(good);
            Weight += good.Weight; 
        }

        
    }
}
