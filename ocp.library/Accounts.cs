using System;
using System.Collections.Generic;
using System.Text;

namespace ocp.library
{
    public class Accounts
    {
        public EmployeeModel CreateAccount(PersonModel applicant)
        {
            EmployeeModel output = new EmployeeModel
            {
                LastName = applicant.LastName,
                FirstName = applicant.FirstName,
                EmailAdress = applicant.FirstName.Substring(0, 1) + applicant.LastName + "@jointech.com"
            };

            return output;
        }
    }
}
