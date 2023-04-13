using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambda
{
    public class ValidationCode
    {
        public void ValidateFirstName()
        {
            Func<string, bool> FirstName = name => name.Length >= 3 && char.IsUpper(name[0]);
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            if (FirstName(firstName) == true)
            {
                Console.WriteLine("Valid first name!");
            }
            else
            {
                Console.WriteLine("Invalid first name. Please enter a first name starting with a capital letter and at least 3 characters.");
            }
        }

        public void ValidateLastName()
        {
            Func<string, bool> LastName = name => name.Length >= 3 && char.IsUpper(name[0]);
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            if (LastName(lastName) == true)
            {
                Console.WriteLine("Valid last name!");
            }
            else
            {
                Console.WriteLine("Invalid last name. Please enter a last name starting with a capital letter and at least 3 characters.");
            }
        }
    }
}
