using System;

namespace Code_Academy_Task__2._1_
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public double height { get; set; }

        public Person(string Name, string Surname, int Age, double Weight, double Height)
        {
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
            this.weight = Weight;
            this.height = Height;
        }

        public override string ToString()
        {
            return $"Name: {name} , Surname: {surname} , Age: {age}, Weight: {weight}, Height: {height}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Karam", "Mammadli", 18, 63, 183);
            Console.WriteLine(person.ToString());
        }
    }
}