using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class AutoShop : IComparable<AutoShop>
    {
        public string CarName { set; get; }
        public int MaxSpeed { get; set; }
        public double Cost { get; set; }
        public byte Discount { get; set; }
        public int ID { get; set; }

        public AutoShop() { }
        public AutoShop(string CarName, int MaxSpeed, double Cost, byte Discount, int ID)
        {
            this.CarName = CarName;
            this.MaxSpeed = MaxSpeed;
            this.Cost = Cost;
            this.Discount = Discount;
            this.ID = ID;
        }

        // Реализуем интерфейс IComparable<T>
        public int CompareTo(AutoShop obj)
        {
            if (this.Cost > obj.Cost)
                return 1;
            if (this.Cost < obj.Cost)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("{4}\tМарка: {0}\tМакс. скорость: {1}\tЦена: {2:C}\tСкидка: {3}%",
                this.CarName, this.MaxSpeed, this.Cost, this.Discount, this.ID);
        }
    }

    class Program
    {
        static void Main()
        {
            List<AutoShop> dic = new List<AutoShop>();

            // Создадим множество автомобилей
            dic.Add(new AutoShop("Toyota Corolla", 180, 300000, 5, 1));
            dic.Add(new AutoShop("VAZ 2114i", 160, 220000, 0, 2));
            dic.Add(new AutoShop("Daewoo Nexia", 140, 260000, 5, 3));
            dic.Add(new AutoShop("Honda Torneo", 220, 400000, 7, 4));
            dic.Add(new AutoShop("Audi R8 Best", 360, 4200000, 3, 5));

            Console.WriteLine("Исходный каталог автомобилей: \n");
            foreach (AutoShop a in dic)
                Console.WriteLine(a);

            Console.WriteLine("\nТеперь автомобили отсортированны по стоимости: \n");
            dic.Sort();
            foreach (AutoShop a in dic)
                Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}