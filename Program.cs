using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_LINQ_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Automobile> automobiles = new List<Automobile>
            {
                new Automobile ("Haval Jolion", 2000000, 160),
                new Automobile ("Audi R8", 5000000, 150),
                new Automobile ("Lada Vesta", 900000, 91),
                new Automobile ("Kia Rio", 1500000, 110)
            };

            automobiles.ForEach(value => Console.WriteLine(value));
            Console.WriteLine();
            Console.WriteLine("Машинки дороже 1 лямчика");

            

            var automobiles1 = from items in automobiles where items.Price > 1000000 select items;

            automobiles1.ToList().ForEach(value => Console.WriteLine(value));

            Console.WriteLine();
            Console.WriteLine("Сортировка машинок по лошадкам");

            var automobiles2 = from items in automobiles group items by items.Power into NewGroup orderby NewGroup.Key select NewGroup;
            foreach (var powers in automobiles2)
            {
                Console.WriteLine($"Мощность {powers.Key}");
                foreach (var cars in powers)
                {
                    Console.WriteLine(cars);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка машинок по прайсу");

            var automobiles3 = from items in automobiles orderby items.Price select items;
            automobiles3.ToList().ForEach(value => Console.WriteLine(value));

            Console.WriteLine();
            Console.WriteLine("Сортировка машинок по лошадкам v.2");

            var automobiles4 = from items in automobiles orderby items.Power select items;
            automobiles4.ToList().ForEach(value => Console.WriteLine(value));
        }
    }
}
