namespace PracticeDay1
{
    public class Class1
    {
        //public class Student
        //{
        //    public string? name;
        //    public int age;

        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Student student = new Student();
        //        student.name = "Siraj";
        //        student.age = 22;
        //        Console.WriteLine($"My name is {student.name} and i am {student.age} years old");

        //        Console.ReadKey();

        //    }  
        // }




        //public class Car
        //{
        //    public string? Brande;
        //    public string? color;
        //    public int year;
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Car car = new Car();
        //        car.Brande = "BMW";
        //        car.color = "Black";
        //        car.year = 2004;

        //        Console.WriteLine($"Brand: {car.Brande}");
        //        Console.WriteLine($"Coolor: {car.color}");
        //        Console.WriteLine($"Year: {car.year}");
        //    }
        //}

        //using Properties
        //public class Employee
        //{
        //    public string Name { get; set; }
        //    public double Salary { get; set; }
        //    public void Display()
        //    {
        //        Console.WriteLine($"Name: {Name}");
        //        Console.WriteLine($"Salary: {Salary}");
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Employee employee1 = new Employee();
        //        employee1.Name = "Siraj";
        //        employee1.Salary = 50000;


        //        Employee employee2 = new Employee();
        //        employee2.Name = "Saqeeb";
        //        employee2.Salary = 50000;

        //        employee1.Display();

        //        Console.WriteLine();

        //        employee2.Display();
        //    }
        //}


        // Consturctor

        public class Mobile
        {
            public string Brande;
            public double Price;

            public Mobile(string a, double b)
            {
                Brande = a;
                Price = b;

            }
        }
        public class Program
        {
            public static void Main()
            {
                Mobile mobile = new Mobile("RedMagic", 98000);
                Console.WriteLine($"Brand: {mobile.Brande}");
                Console.WriteLine($"Price: {mobile.Price}");

                Console.ReadKey();

            }
        }
    }
}
