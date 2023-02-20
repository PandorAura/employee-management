namespace EmployeeManagement
{
    public class NameBuilder : INameBuilder
    {
        private Name name;

        public NameBuilder() 
        { 
            this.name = new Name();
        }
        public void BuildFirstName(string firstName)
        {
            name.SetFirstName(firstName);
        }

        public void BuildMiddleName(string middleName) 
        {
            name.SetMiddleName(middleName);
        }

        public void BuildLastName(string lastName)
        {
            name.SetLastName(lastName);
        }

        public Name GetName()
        {
            return name;
        }
    }
}
