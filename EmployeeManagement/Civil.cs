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

        public void Construct(string firstName, string lastName)
        {
            this.nameBuilder.BuildFirstName(firstName);
            this.nameBuilder.BuildLastName(lastName);
        }
    }
}
