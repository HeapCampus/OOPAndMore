#define ExampleAsync


using Hello_Principles;
using System.Security.Cryptography.X509Certificates;

namespace Hello_Principles
{
#if Classes
    public class Car
    {
        // Properties
        public string Brand;
        public string Model;
        public int Year;
        public string Color;

        // Constructor
        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            Console.WriteLine("Car created: " + Brand + " " + Model);
        }

        // Destructor
        ~Car()
        {
            Console.WriteLine("Car destroyed: " + Brand + " " + Model);
        }

        // Method
        public void Drive()
        {
            Console.WriteLine(Brand + " " + Model + " is driving.");
        }

        // Method
        public void Stop()
        {
            Console.WriteLine(Brand + " " + Model + " has stopped.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Car object
            Car myCar = new Car("Toyota", "Corolla", 2020, "Blue");

            // Using methods of the Car class
            myCar.Drive();
            myCar.Stop();

            // The Car object will be destroyed when it goes out of scope
        }
    }

#endif
#if Encapsulation

    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            person.Display();
        }
    }

#endif

#if Abstraction

    public abstract class Shape
    {
        public abstract double Area(); // Soyut method

        public void Display()
        {
            Console.WriteLine("The area is: " + Area());
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area() // Soyut methodun implemente edilmesi
        {
            return Math.PI * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(5);
            shape.Display();
        }
    }

#endif

#if Inheritance
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat(); // Kalıtım sayesinde Animal sınıfının methoduna erişim
        dog.Bark();
    }
}

#endif

#if Interfaces
public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable movable = new Car();
        movable.Move();
    }
}

#endif

#if Polymorphism
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound...");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.MakeSound(); // Output: Bark
        myCat.MakeSound(); // Output: Meow
    }
}

#endif

#if Composition
public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

public class Car
{
    private Engine engine = new Engine();

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car started");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.StartCar();
    }
}

#endif

#if Aggregation
public class Wheel
{
    public void Rotate()
    {
        Console.WriteLine("Wheel is rotating");
    }
}

public class Car
{
    private List<Wheel> wheels = new List<Wheel>();

    public Car()
    {
        for (int i = 0; i < 4; i++)
        {
            wheels.Add(new Wheel());
        }
    }

    public void Drive()
    {
        foreach (var wheel in wheels)
        {
            wheel.Rotate();
        }
        Console.WriteLine("Car is driving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Drive();
    }
}

#endif

#if Association
public class Driver
{
    public void Drive(Car car)
    {
        car.Drive();
        Console.WriteLine("Driver is driving the car");
    }
}

public class Car
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Driver driver = new Driver();
        driver.Drive(car);
    }
}

#endif

#if DependencyInjection
public interface IEngine
{
    void Start();
}

public class Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

public class Car
{
    private IEngine engine;

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car started");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IEngine engine = new Engine();
        Car car = new Car(engine);
        car.StartCar();
    }
}

#endif

#if Example1
//Assignment: Zoo Management System

//In this assignment, you will create a zoo management system. The system will include different types of animals, each with their own abilities to make sounds and move. This will help you practice the principles of object-oriented programming (OOP), including abstraction, inheritance, interfaces, and polymorphism.

//Requirements

//Abstraction:

//Create an abstract class called Animal. This class should contain common properties and methods for all animals.
//The Animal class should include properties for the animal's name, age, and species.
//The Animal class should have abstract methods MakeSound() and Move().
//Inheritance:

//Create derived classes Lion, Elephant, Bird, and Bear that inherit from the Animal class.
//Each derived class should implement the MakeSound() and Move() methods uniquely.
//Interfaces:

//Create an interface ICarnivore with a method Hunt().
//Create an interface IHerbivore with a method Graze().
//The Lion class should implement the ICarnivore interface.
//The Elephant class should implement the IHerbivore interface.
//The Bear class should implement both the ICarnivore and IHerbivore interfaces.
//Polymorphism:

//Create a Zoo class that contains a collection of Animal objects.
//The Zoo class should have methods to add an animal (AddAnimal), make all animals make sounds (MakeAllAnimalsSound), and list all animals (ListAllAnimals).

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public abstract void MakeSound();
    public abstract void Move();
}

public interface ICarnivore
{
    void Hunt();
}

public interface IHerbivore
{
    void Graze();
}
public class Lion : Animal, ICarnivore
{
    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }

    public override void Move()
    {
        Console.WriteLine("Lion is running");
    }

    public void Hunt()
    {
        Console.WriteLine("Lion is hunting");
    }
}

public class Elephant : Animal, IHerbivore
{
    public override void MakeSound()
    {
        Console.WriteLine("Trumpet");
    }

    public override void Move()
    {
        Console.WriteLine("Elephant is walking");
    }

    public void Graze()
    {
        Console.WriteLine("Elephant is grazing");
    }
}

public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp");
    }

    public override void Move()
    {
        Console.WriteLine("Bird is flying");
    }
}

public class Bear : Animal, ICarnivore, IHerbivore
{
    public override void MakeSound()
    {
        Console.WriteLine("Growl");
    }

    public override void Move()
    {
        Console.WriteLine("Bear is walking");
    }

    public void Hunt()
    {
        Console.WriteLine("Bear is hunting");
    }

    public void Graze()
    {
        Console.WriteLine("Bear is grazing");
    }
}

public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void MakeAllAnimalsSound()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }

    public void ListAllAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Species: {animal.Species}, Age: {animal.Age}");
        }
    }

    public void MoveAllAnimals()
    {
        foreach (var animal in animals)
        {
            animal.Move();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Lion lion = new Lion { Name = "Leo", Age = 5, Species = "Lion" };
        Elephant elephant = new Elephant { Name = "Dumbo", Age = 10, Species = "Elephant" };
        Bird bird = new Bird { Name = "Tweety", Age = 2, Species = "Bird" };
        Bear bear = new Bear { Name = "Baloo", Age = 7, Species = "Bear" };

        zoo.AddAnimal(lion);
        zoo.AddAnimal(elephant);
        zoo.AddAnimal(bird);
        zoo.AddAnimal(bear);

        zoo.ListAllAnimals();
        zoo.MakeAllAnimalsSound();
        zoo.MoveAllAnimals();
    }
}

#endif

#if SOLIDPrinciples

    //
    //1. Single Responsibility Principle (SRP)
    //2. Open/Closed Principle (OCP)
    //3. Liskov Substitution Principle (LSP)
    //4. Interface Segregation Principle (ISP)
    //5. Dependency Inversion Principle (DIP)

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }

    //    public void Save()
    //    {
    //        // Save employee to database
    //    }

    //    public void GenerateReport()
    //    {
    //        // Generate report for employee
    //    }
    //}

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }
    //}

    //public class EmployeeDatabase
    //{
    //    public void Save()
    //    {
    //        // Save employee to database
    //    }
    //}

    //public class EmployeeReporter
    //{
    //    public void GenerateReport()
    //    {
    //        // Generate report for employee
    //    }
    //}

    //public class Shape
    //{
    //    public double Radius { get; set; }
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //    public string ShapeType { get; set; }

    //    public double CalculateArea()
    //    {
    //        if (ShapeType == "Circle")
    //        {
    //            return Math.PI * Radius * Radius;
    //        }
    //        else if (ShapeType == "Rectangle")
    //        {
    //            return Width * Height;
    //        }
    //        throw new InvalidOperationException("Invalid shape type");
    //    }
    //}

    //public abstract class Shape
    //{
    //    public abstract double CalculateArea();
    //}

    //public class Circle : Shape
    //{
    //    public double Radius { get; set; }

    //    public override double CalculateArea()
    //    {
    //        return Math.PI * Radius * Radius;
    //    }
    //}

    //public class Rectangle : Shape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public override double CalculateArea()
    //    {
    //        return Width * Height;
    //    }
    //}

    //public class Document
    //{
    //    public virtual void Print()
    //    {
    //        // Print the document
    //    }
    //}

    //public class ReadOnlyDocument : Document
    //{
    //    public override void Print()
    //    {
    //        throw new NotImplementedException("Read-only documents can't be printed");
    //    }
    //}

    //public abstract class Document
    //{
    //    public abstract void Print();
    //}

    //public class RegularDocument : Document
    //{
    //    public override void Print()
    //    {
    //        // Print the document
    //    }
    //}

    //public class PdfDocument : Document
    //{
    //    public override void Print()
    //    {
    //        // Print PDF
    //    }
    //}

    //public interface IWorker
    //{
    //    void Work();
    //    void Eat();
    //}

    //public class Worker : IWorker
    //{
    //    public void Work()
    //    {
    //        // Working
    //    }

    //    public void Eat()
    //    {
    //        // Eating
    //    }
    //}

    //public class Robot : IWorker
    //{
    //    public void Work()
    //    {
    //        // Working
    //    }

    //    public void Eat()
    //    {
    //        throw new NotImplementedException("Robots don't eat");
    //    }
    //}

    //public interface IWorker
    //{
    //    void Work();
    //}

    //public interface IEater
    //{
    //    void Eat();
    //}

    //public class Worker : IWorker, IEater
    //{
    //    public void Eat()
    //    {
    //        // Eating
    //    }

    //    public void Work()
    //    {
    //        // Working
    //    }
    //}

    //public class Robot : IWorker
    //{
    //    public void Work()
    //    {
    //        // Working
    //    }
    //}

    //public class EmailSender
    //{
    //    public void SendMessage(string message)
    //    {
    //        // Send email
    //    }
    //}

    //public class Notification
    //{
    //    private readonly EmailSender _emailSender;

    //    public Notification()
    //    {
    //        _emailSender = new EmailSender();
    //    }

    //    public void Notify(string message)
    //    {
    //        _emailSender.SendMessage(message);
    //    }
    //}

    public interface IMessageSender
    {
        void Send(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            // Send mail
        }
    }

    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            // Send sms
        }
    }

    public class Notification
    {
        private readonly IMessageSender _messageSender;

        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Notify(string message)
        {
            _messageSender.Send(message);
        }
    }


#endif

#if Generics

    public class MyGenericClass<T>
    {
        private T data;

        public MyGenericClass(T value)
        {
            data = value;
        }

        public T GetData()
        {
            return data;
        }

        public void SetData(T value)
        {
            data = value;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> intInstance = new MyGenericClass<int>(123);
            Console.WriteLine(intInstance.GetData()); // 123

            MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello");
            Console.WriteLine(stringInstance.GetData()); // Hello

            Pair<int, string> pair = new Pair<int, string>(43, "forty three");
            pair.DisplayPair();
        }
    }

    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void DisplayPair()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }
    }


#endif

#if Extensions

    public static class ListExtensions
    {
        public static void PrintAll<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.PrintAll();
        }
    }


#endif

#if Async
    
    public class MyClass
    {
        public async Task MyAsyncMethod()
        {
            // Zaman alan bir işlemi simüle etmek için Task.Delay kullanılır.
            await Task.Delay(1000);
            Console.WriteLine("Bu mesaj 1 saniye gecikmeden sonra görüntülenir.");
        }

        public async Task<int> GetDataAsync()
        {
            // Zaman alan bir işlemden veri almak için simülasyon
            await Task.Delay(2000);
            return 42; // Örneğin bir veri sonucu döndürülür.
        }

    }


    class Program
    {

        static async Task Main(string[] args)
        {
            MyClass myClass = new MyClass();

            await myClass.MyAsyncMethod();

            int val = await myClass.GetDataAsync();

            Console.WriteLine(val);
        }
    }

#endif

#if ExampleAsync

using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        string city = "Istanbul";
        string weatherData = await GetWeatherDataAsync(city);
        Console.WriteLine(weatherData);

        city = "Ankara";
        string weatherData2 = await GetWeatherDataAsync(city);
        Console.WriteLine(weatherData2);

        city = "Paris";
        string weatherData3 = await GetWeatherDataAsync(city);
        Console.WriteLine(weatherData3);
    }

    private static async Task<string> GetWeatherDataAsync(string city)
    {
        try
        {
            // wttr.in servisine istek gönder
            string url = $"http://wttr.in/{city}?format=%C+%t";
            HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Başarısız olursa hata fırlatır

            // Yanıtı string olarak al
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nHata: ");
            Console.WriteLine(e.Message);
            return null;
        }
    }
}

#endif

}

