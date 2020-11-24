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

            Accounts accountProrccesser = new Accounts();

            foreach (var applicant in applicants)
            {                            
                employees.Add(accountProrccesser.CreateAccount(applicant));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"employee name: {employee.FirstName} {employee.LastName}, email adress: {employee.EmailAdress}");
            }
        }
    }
}
