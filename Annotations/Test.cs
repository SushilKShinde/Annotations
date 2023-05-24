using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Annotations
{
    internal class Test
    {
        public static void Display()
        {
            Console.WriteLine("Employee class validation");

            Employee employee = new Employee();
            employee.name = "Sushil";           
            employee.age = 23;                                                                                                            
            employee.phoneNumber = "91 9902141561";
            employee.email = "sksg@mail.com";

            ValidationContext context = new ValidationContext(employee, null, null);  //(object, service, dictionaries)
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, results, true);

            if(!valid)
            {
                foreach(ValidationResult result in results)
                {
                    Console.Write($"Member name: {result.MemberNames}");
                    Console.WriteLine($"ErrorMessage : {result.ErrorMessage}");
                }
            }
            else
            {
                Console.WriteLine($"Name: {employee.name} \n Age: {employee.age} \n PhoneNumber: {employee.phoneNumber} \n Email: {employee.email} ");

            }
            Console.ReadKey();
        }
        
    }
}
