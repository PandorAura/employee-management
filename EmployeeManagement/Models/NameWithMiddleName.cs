namespace EmployeeManagement.Models
{
    public class NameWithMiddleName : Name
    {
        public string? MiddleName { get; set; }

        public override string DisplayName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
