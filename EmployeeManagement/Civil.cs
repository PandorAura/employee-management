namespace EmployeeManagement
{
    public class Civil
    {
        private NameBuilder nameBuilder;

        public Civil( NameBuilder  nameBuilder) 
        { 
            this.nameBuilder = nameBuilder;
        }

        public Name GetName()
        {
            return this.nameBuilder.GetName();
        }

        public void ConstructNameWithoutMiddleName(string firstName, string lastName)
        {
            this.nameBuilder.BuildFirstName(firstName);
            this.nameBuilder.BuildLastName(lastName);
        }
        public void ConstructNameWithMiddleName(string firstName, string lastName, string middleName)
        {
            this.nameBuilder.BuildFirstName(firstName);
            this.nameBuilder.BuildMiddleName(middleName);
            this.nameBuilder.BuildLastName(lastName);
        }
    }
}
