using System;

namespace Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        private decimal salary;


        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            //FirstName = firstName;
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            //this.firstName = firstName;
            //this.lastName = lastName;
            //this.age = age;
            //this.salary = salary;

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get => firstName;
            //internal set => firstName = value; //?? vad innebär internal autogenererad,
            internal set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!", nameof(FirstName));
                }
                else
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get => lastName;
            //internal set => lastName = value;
            internal set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!", nameof(LastName));
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public int Age
        {
            get => age;
            internal set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative.", nameof(Age));
                }
                else
                {
                    age = value;
                }
            }
        }

        public decimal Salary
        {
            get => salary;
            //private set; 
            //?? Privat blir det att den bara kan använda i denna klass
            //tex så att konstruktorn kan använda den men inte utifrån?!
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollar!", nameof(Salary));
                }
                else
                {
                    salary = value;
                }
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                salary += (salary * percentage / 2 / 100);
            }
            else
            {
                salary += (salary * percentage / 100);
            }
        }

        public override string ToString()
        {
            //Del 1
            //return FirstName + " " + LastName + " is " + Age + " years old.";

            //Del 2
            //return FirstName + " " + LastName + " receives " + Salary + " dollars.";
            return $"{FirstName} {LastName} receives {Salary:N} dollars.";
        }
    }
}