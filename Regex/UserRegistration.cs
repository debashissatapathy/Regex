using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class UserRegistration
    {
        public bool FirstName(string FName)
        {
            bool status;
            string firstname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(FName))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("First name ({0}) is valid", FName);
                Console.ResetColor();

            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please Enter First Letter Capital \n");
                Console.ResetColor();

            }
            return status;
        }
        public bool LastName(String LName)
        {
            bool status;
            string lastname = "^[A-z]{1}[a-z]{2,}$";
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(LName))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Last name ({0}) is valid", LName);
                Console.ResetColor();

            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please Enter First Letter Capital \n");
                Console.ResetColor();

            }
            return status;
        }
        public bool Email_Id(string Email)
        {
            bool status;
            string email = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(email);

            if (regex.IsMatch(Email))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} is valid emailId.", Email);
                Console.ResetColor();

            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} is not valid emailId.", Email);
                Console.ResetColor();

            }
            return status;
        }
        public bool Mobile_Number(String Mobile)
        {
            bool status;
            string number = "^(\\d{2}\\s)+\\d{10}$";
            Regex regex = new Regex(number);
            if (regex.IsMatch(Mobile))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} is valid mobile number.", Mobile);
                Console.ResetColor();
            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} is not valid mobile number.", Mobile);
                Console.ResetColor();

            }
            return status;
        }
        public bool PasswordRule1(string Password)
        {
            bool status;
            string password = "^[a-za-z0-9]{8,}$";
            Regex regex = new Regex(password);

            if (regex.IsMatch(Password))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Entered value is valid password.");
                Console.ResetColor();
            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entered value is not valid password.");
                Console.ResetColor();
            }
            return status;
        }
        public bool PasswordRule2(string Password2)
        {
            bool status;
            var password = "^(?=.*[A-Z])[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(password);

            if (regex.IsMatch(Password2))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password is Valid.");
                Console.ResetColor();

            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter valid Password.");
                Console.ResetColor();

            }
            return status;
        }
        public bool PasswordRule3(string Password3)
        {
            bool status;
            string password = "^(?=.*[0-9A-Z])[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(password);

            if (regex.IsMatch(Password3))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password is Valid.");
                Console.ResetColor();

            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter valid Password.");
                Console.ResetColor();

            }
            return status;
        }
        public bool PasswordRule4(string Password4)
        {
            bool status;
            var password = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(password);

            if (regex.IsMatch(Password4))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password is Valid.");
                Console.ResetColor();

            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter valid Password.");
                Console.ResetColor();
            }
            return status;
        }
        public bool EmailValidation(string Email)
        {
            bool status;
            string email = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$"; //"^[A-Za-z0-9](.[A-Za-z0-9])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(email);

            if (regex.IsMatch(Email))
            {
                status = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email id is valid");
                Console.ResetColor();
            }
            else
            {
                status = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid email id");
                Console.ResetColor();
            }
            return status;
        }
    }
}
