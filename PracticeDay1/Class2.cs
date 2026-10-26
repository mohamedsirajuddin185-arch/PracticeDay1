using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDay1
{
    public class Class2
    {
        //Encapsulation practice
        //public class BankAccount
        //{
        //    private int _balance = 0;

        //    public void Deposite(int amount)
        //    {
        //        _balance += amount;
        //    }
        //    public int GetBalance()
        //    {
        //        return _balance;
        //    }

        //    public class Program
        //    {
        //        public static void Main()
        //        {
        //            BankAccount account = new BankAccount();
        //            account.Deposite(10000);

        //            Console.WriteLine($"Balance: {account.GetBalance()}");
        //        }
        //    }
       // }


        //public class BankAccount
        //{
        //    private int pin;
        //    public void SetPin(int newpin)
        //    {
        //        pin = newpin;
        //        Console.WriteLine("PIN set Successfully");
        //    }
        //    public void DisplayPin()
        //    {
        //        Console.WriteLine("Your PIN is Protected");
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        BankAccount bankaccount = new BankAccount();

        //        bankaccount.SetPin(2004);
        //        bankaccount.DisplayPin();
        //    }
        //}



        // Abstract practice

        //public abstract class Vehicle
        //{
        //    public abstract void Start();
        //    public void Stop()
        //    {
        //        Console.WriteLine("Vehicle Stopped");
        //    }
        //}
        //public class Car:Vehicle
        //{
        //    public override void Start()
        //    {
        //        Console.WriteLine("Car started");
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Car car = new Car();
        //        car.Start();
        //        car.Stop();
        //    }
        //}

        public abstract class Animal
        {
            public abstract void Sound();
        }
        public class Dog : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Dog is barking ");
            }
        }
        public class Cat:Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Cat make sound like Meow");
            }
        }
        public class Program
        {
            public static void Main()
            {
                Dog dog = new Dog();
                dog.Sound();

                Cat cat = new Cat();
                cat.Sound();

                Console.ReadKey();
            }
        }
        
    }
}
