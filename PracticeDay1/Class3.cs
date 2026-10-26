using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDay1
{
    public class Class3
    {

        //Inheritance

    //    public class Program
    //    {
    //        public static void Main()
    //        {
    //            Dinosor dinosor = new Dinosor();

    //            dinosor.Eat();
    //            dinosor.Scream();
    //        }
    //    }
        
    //}
    //public class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal is eating");
    //    }
    //}
    //public class Dinosor : Animal
    //{
    //    public void Scream()
    //    {
    //        Console.WriteLine("Dinosor is Screaming");
    //    }



        public class Program
        {
            public static void Main()
            {
                Product product = new Product();

                product.Id = 1;
                product.Name = "BMW s1000RR";
                product.Price = 10000;

                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
            }
        }
        public class Product
        {
            public int Id { get; set; }
            public string? Name { get; set;}
            public double Price { get; set; }
        }

    }
   
}
