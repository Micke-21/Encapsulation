namespace Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
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

        public override string ToString()
        {
            return FirstName + " " + LastName + " is " + Age + " years old.";
        }
    }
}