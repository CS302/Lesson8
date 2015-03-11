using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Lorry
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionLorry lorry1 = new CollectionLorry(300);
            try
            {
                lorry1.Add(new Book("Война и Мир", 50));
                lorry1.Add(new Book("Преступление и накзание", 30));
                lorry1.Add(new Book("Троелсен", 150));
                lorry1.Add(new Book("Рихтер", 250));

                lorry1.Add(new Disk("Windows 8.1", 25));
                lorry1.Add(new Disk("Photoshop", 25));
            }
            catch (OverflowGoodsException ex)
            {
                ex.good.Print();
            }
            

            Console.WriteLine(lorry1.Weight);

            foreach (Good good in lorry1)
	            good.Print();
            Console.WriteLine();

            lorry1.RemoveAt(2);
            Console.WriteLine(lorry1.Weight);
            foreach (Good good in lorry1)
                good.Print();
            

            Console.ReadLine();
        }
    }
}
