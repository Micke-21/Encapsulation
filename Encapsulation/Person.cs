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
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get => firstName;
            //internal set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            //internal set => lastName = value;
        }
        public int Age
        {
            get => age;
            //internal set => age = value;
        }
        public decimal Salary
        {
            get => salary;
            //private set;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                salary += salary * percentage / 2 / 100;
            }
            else
            {
                salary += salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            //return FirstName + " " + LastName + " is " + Age + " years old.";
            //return FirstName + " " + LastName + " receives " + Salary + " dollars.";
            return $"{FirstName} {LastName} receives {Salary:N} dollars.";
        }
    }
}