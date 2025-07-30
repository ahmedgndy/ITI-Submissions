namespace OOP_day_7_task_1
{
    using System;

    class Animal
    {
        protected string name;
        protected string color;
        protected int age;

        public void SetName(string n)
        {
            name = n;
        }

        public void SetColor(string c)
        {
            color = c;
        }

        public void SetAge(int a)
        {
            age = a;
        }

        public string GetName()
        {
            return name;
        }

        public string GetColor()
        {
            return color;
        }

        public int GetAge()
        {
            return age;
        }

        public virtual void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(name + " is barking!");
        }
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine(name + " is eating quietly.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName("Max");
            dog.SetColor("Brown");
            dog.SetAge(4);
            Console.WriteLine($"Dog: {dog.GetName()}, {dog.GetColor()}, {dog.GetAge()} years old");
            dog.Eat();
            dog.Sleep();
            dog.Bark();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.SetName("Luna");
            cat.SetColor("Black");
            cat.SetAge(2);
            Console.WriteLine($"Cat: {cat.GetName()}, {cat.GetColor()}, {cat.GetAge()} years old");
            cat.Eat();
            cat.Sleep();
        }
    }
   }

