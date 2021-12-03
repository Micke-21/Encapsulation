using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = 5;
            //var persons = new List<Person>();

            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            //    persons.Add(person);
            //}

            //persons.OrderBy(p => p.FirstName)
            //    .ThenBy(p => p.Age)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ToString()));



            //2. Salary Increase
            var si = new StartUp();
            si.MySalaryIncrease();
        }
    }
}
