namespace EmployeeManagement.Models
{
    public class Name
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
      
        public virtual string DisplayName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
