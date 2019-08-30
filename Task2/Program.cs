using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat01 = new Cat("Tibby", 2);
            Cat cat02 = new Cat("Smudge", 1);
            Cat.Age(cat01);
            Cat.Age(cat02);
            var json = new JavaScriptSerializer().Serialize(cat01);
        }
    }

    class Cat
    {
        private string name;
        private int age;

        public Cat(string catName, int catAge)
        {
            name = catName;
            age = catAge;
        }

        public static object Age(Cat Cat)
        {
            Cat.age = Cat.age + 5;
            return Cat.age;
        }
    }
}
