namespace EmployeeManagement
{
    public interface INameBuilder
    {
        public void BuildFirstName(string firstName);
        public  void BuildLastName(string lastName);
        public Name GetName();
    }
}
