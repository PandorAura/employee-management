using EmployeeManagement.Models;

namespace EmployeeManagement.Services.Validators
{
    public class NameValidator
    {
        public bool IsNameValid(Name name)
        {
            if (name == null)
            {
                return false;
            }
            if (name.FirstName == "" || name.LastName == "")
            {
                return false;
            }
            return true;
        }
    }
}
