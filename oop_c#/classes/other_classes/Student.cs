namespace classes.other_classes
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;

        public  Student(int id, string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }
    }
}