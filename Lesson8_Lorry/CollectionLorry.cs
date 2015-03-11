using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    class CollectionLorry : List<Good>
    {
        private int maxWeight;
        public int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public CollectionLorry(int maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        public void Add(Good good)
        {
            if (good.Weight + Weight > maxWeight)
            {
                /*Console.WriteLine("Невозможно добавить товар:");
                good.Print();
                Console.WriteLine();
                return;*/
                OverflowGoodsException ex = new OverflowGoodsException();
                ex.good = good;
                throw ex;
            }
            base.Add(good);
            Weight += good.Weight;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                Weight -= base[index].Weight;
                base.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Элемента с таким индексом нет");
            }
        }
    }

    [Serializable]
    public class OverflowGoodsException : Exception
    {
        public Good good;
        public OverflowGoodsException() { }
        public OverflowGoodsException(string message) : base(message) { }
        public OverflowGoodsException(string message, Exception inner) : base(message, inner) { }
        protected OverflowGoodsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
