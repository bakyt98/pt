using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Ali", 14);
            Person b = new Person("Ali", 15);
            Person c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
    class Person {
        string name;
        int age;
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public static Person operator +(Person a, Person b) {
            return new Person (a.name+b.name, a.age + b.age);

        }
        public override string ToString()
        {
            return this.name + " " + this.age;
        }
    }
}
