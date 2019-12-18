using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var mainPerson = new Person { 
            Age = 12,
            BirthDate = DateTime.Now,
            IdInfo = new IdInfo(10),
            Name = "Pepi Tsesmeli"
            };
            //Console.WriteLine("Main Person " + mainPerson.Age );
            //Console.WriteLine("Main Person " + mainPerson.BirthDate);
            //Console.WriteLine("Main Person " + mainPerson.Name);
            //Console.WriteLine("Main Person " + mainPerson.IdInfo.IdNumber);
            var shallowCopy = mainPerson.ShallowCopy();
            //Console.WriteLine("Shallow Copy " + shallowCopy.Age);
            //Console.WriteLine("Shallow Copy " + shallowCopy.BirthDate);
            //Console.WriteLine("Shallow Copy " + shallowCopy.Name);
            //Console.WriteLine("Shallow Copy " + shallowCopy.IdInfo.IdNumber);
            var deepCopy = mainPerson.DeepCopy();
            //Console.WriteLine("Shallow Copy " + deepCopy.Age);
            //Console.WriteLine("Shallow Copy " + deepCopy.BirthDate);
            //Console.WriteLine("Shallow Copy " + deepCopy.Name);
            //Console.WriteLine("Shallow Copy " + deepCopy.IdInfo.IdNumber);

            mainPerson.Age = 32;
            mainPerson.BirthDate = Convert.ToDateTime("1900-01-01");
            mainPerson.Name = "Frank";
            mainPerson.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(mainPerson);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(shallowCopy);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(deepCopy);
        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
