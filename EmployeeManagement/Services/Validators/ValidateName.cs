using EmployeeManagement.Models;

namespace EmployeeManagement.Services.Validators
{
    public class ValidateName
    {
        public static bool IsNameValid(Name name)
        {
            if (name == null)
            {
                return false;
            }
            if (name.firstName == "" || name.lastName == "")
            {
                return false;
            }
            return true;
        }
    }
}
