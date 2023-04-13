using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    public class ValidationCode
    {
        //FIRST NAME
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

        //LAST NAME
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

        // EMAIL ADDRESS
        public void ValidateEmail()
        {
            Func<string, bool> Email = email1 =>
            {
                string pattern = @"^[0-9a-z._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email1);
            };

            Console.Write("Please enter your email address: ");
            string email = Console.ReadLine();
            if (Email(email) == true)
            {
                Console.WriteLine("Valid email!");
            }
            else
            {
                Console.WriteLine("Invalid email. Please enter a valid email address.");
            }
        }

        //PHONE NUMBER
        public void ValidatePhone()
        {
            Func<string, bool> PhoneNumber = phoneNum =>
            {
                string pattern = @"^[1-9]{2} [0-9]{10}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(phoneNum);
            };
            Console.Write("Please enter your Phone Number: ");
            string phone = Console.ReadLine();
            if (PhoneNumber(phone) == true)
            {
                Console.WriteLine("Valid Phone Number!");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number. Please enter a valid Phone Number.");
            }
        }

        //PASSWORD
        public void ValidatePassword()
        {
            Func<string, bool> Password = pass =>
            {
                string pattern = @"^.{8,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(pass);
            };
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            if (Password(password) == true)
            {
                Console.WriteLine("Valid Password!");
            }
            else
            {
                Console.WriteLine("Invalid Password. Please enter a valid Password.");
            }
        }



    }
}
