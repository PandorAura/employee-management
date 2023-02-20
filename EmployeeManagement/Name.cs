namespace EmployeeManagement
{
    public class Name : IName
    {
        private string firstName, lastName, middleName;

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetMiddleName(string middleName)
        {
            this.middleName = middleName;
        }

        public string GetFirstName() { return this.firstName; }
        public string GetLastName() { return this.lastName;}
    }
}
