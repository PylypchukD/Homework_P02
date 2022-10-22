using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции. 
             * Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей. 
             */
            List<Order> orders = new List<Order>()
            {
                {new Order(new Consumer("Vitalik"), new Category("Computers")) },
                {new Order(new Consumer("Vitalik"), new Category("Cars")) },
                {new Order(new Consumer("Sergiy"), new Category("Vino")) },
                {new Order(new Consumer("Mukola"), new Category("Cars")) },
            };

            Console.WriteLine("Найдем тех, кто купил cars:");
            var resultCars = orders.FindAll(x => x.category.Name == "Cars").ToList();
            foreach (var item in resultCars)
            {
                Console.WriteLine(item.consumer);
            }

            Console.WriteLine("Найдем все категории, которые купил Vitalik:");
            var resultConsumer = orders.FindAll(x => x.consumer.Name == "Vitalik").ToList();
            foreach (var item in resultConsumer)
            {
                Console.WriteLine(item.category);
            }

            Console.ReadKey();
        }

    }


    class Consumer
    {
        public string Name { get; set; }
        public Consumer(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }

    class Category
    {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
    class Order
    {
        public Consumer consumer;
        public Category category;
        public Order(Consumer consumer, Category category)
        {
            this.consumer = consumer;
            this.category = category;
        }
        public override string ToString()
        {
            return $"{consumer} {category}";
        }
    }

}
