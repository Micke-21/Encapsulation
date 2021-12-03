using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class StartUp
    {
        public void MySalaryIncrease()
        {
            Console.WriteLine("Hur många rader");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            Console.WriteLine("Ange förnamn efternamn ålder lön");
            for (int i = 0; i < lines; i++)
            {
                Console.Write(i+1+": ");
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            Console.WriteLine("Ange bonus i procent.");
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
