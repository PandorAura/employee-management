﻿using EmployeeManagement.Builders;
using EmployeeManagement.Models;
using EmployeeManagement.Services.Validators;

namespace EmployeeManagement
{
    public class NameService
    {
        private NameBuilder nameBuilder;

        public NameService(NameBuilder nameBuilder)
        {
            this.nameBuilder = nameBuilder;
        }

        public void ConstructName(string firstName,string? middleName, string lastName)
        {
            nameBuilder.WithFirstName(firstName);
            if (middleName!= null)
            {
                nameBuilder.;
            }
            nameBuilder.WithLastName(lastName);

            if (!ValidateName.IsNameValid(GetName()))
            {
                throw new Exception();
            }
        }
     
    }
}
