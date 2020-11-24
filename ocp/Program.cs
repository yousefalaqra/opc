using ocp.library;
using System;
using System.Collections.Generic;

namespace ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Jo", LastName = "Aqra"},
                new PersonModel { FirstName = "Ibrahen", LastName = "Ali"},
                new PersonModel { FirstName = "Deena", LastName = "Yameen"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var applicant in applicants)
            {
                // create employee account\
                EmployeeModel employee = new EmployeeModel
                {
                    FirstName = applicant.FirstName,
                    LastName = applicant.LastName,
                    EmailName = applicant.FirstName.Substring(0, 1) + applicant.LastName + "@jointech.com"
                };

                employees.Add(employee);
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"employee name: {employee.FirstName} {employee.LastName}, email adress: {employee.EmailName}");
            }
        }
    }
}
