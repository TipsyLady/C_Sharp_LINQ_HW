using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_LINQ_HW
{
    class Automobile
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public double Power { get; set; }

        public Automobile (string model, double price, double power)
        {
            Model = model;
            Price = price;
            Power = power;
        }

        //public static void Print(Automobile automobile)
        //{
        //   Console.WriteLine(automobile.ToString());
        //}

        public override string ToString()
        {
            return $"Марка: {Model}, Стоимость: {Price}, Мощность: {Power}";
        }
    }
}
