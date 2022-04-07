using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>(); 
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] personData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name=personData[0];  
                int id=int.Parse(personData[1]);
                int age=int.Parse(personData[2]);

                Person newPerson = new Person(name, id, age);
                listOfPersons.Add(newPerson);   


                input = Console.ReadLine();
            }
            listOfPersons = listOfPersons.OrderBy(p => p.Age).ToList();
            foreach (Person person in listOfPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        public Person(string name, int id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {

            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
