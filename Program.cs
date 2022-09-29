using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public class Person
        {
            public int BirthYear;
            String firstname, lastname;
            public Person(string firstname, string lastname)
            {
                this.firstname = firstname;
                this.lastname = lastname;
            }
            public string GetFullName()
            {
                return firstname + " " + lastname;
            }
            public int GetAge()
            {
                return BirthYear;
            }

        static void Main(string[] args)
        {
            Person person1 = new Person("Angel", "Locsin");
            person1.BirthYear = 30;
            Console.WriteLine("Hello " + person1.GetFullName());
            Console.WriteLine("You are " + person1.GetAge() + " years old.");

        }
        }
    }
}
