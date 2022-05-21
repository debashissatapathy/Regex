using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem Using Regular Expression!");

            while (true)
            {
                Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName\n3)Email ID\n4)Mobile Number\n5)Password of 8digits\n6)Password with atleast 1 capital letter\n7)Atleast 1number\n8)Atleast 1 special Character\n9)Different Email Formats");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter your First Name");
                        string FName = Console.ReadLine();
                        UserRegistration first = new UserRegistration();
                        first.FirstName(FName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name: ");
                        string LName = Console.ReadLine();
                        UserRegistration last = new UserRegistration();
                        last.LastName(LName);
                        break;
                    case 3:
                        Console.WriteLine("Enter your emailId: ");
                        string Email = Console.ReadLine();
                        UserRegistration id = new UserRegistration();
                        id.Email_Id(Email);
                        break;
                    case 4:
                        Console.WriteLine("Enter your mobile number");
                        string Mobile = Console.ReadLine();
                        UserRegistration mob = new UserRegistration();
                        mob.Mobile_Number(Mobile);
                        break;
                    case 5:
                        Console.WriteLine("Enter password");
                        string Password = Console.ReadLine();
                        UserRegistration pass = new UserRegistration();
                        pass.PasswordRule1(Password);
                        break;
                    case 6:
                        Console.WriteLine("Enter password");
                        string Password2 = Console.ReadLine();
                        UserRegistration pass2 = new UserRegistration();
                        pass2.PasswordRule2(Password2);
                        break;
                    case 7:
                        Console.WriteLine("Enter password");
                        string Password3 = Console.ReadLine();
                        UserRegistration pass3 = new UserRegistration();
                        pass3.PasswordRule3(Password3);
                        break;
                    case 8:
                        Console.WriteLine("Enter password");
                        string Password4 = Console.ReadLine();
                        UserRegistration pass4 = new UserRegistration();
                        pass4.PasswordRule4(Password4);
                        break;
                    case 9:
                        Console.WriteLine("Enter email id: ");
                        string Email2 = Console.ReadLine();
                        UserRegistration mail = new UserRegistration();
                        mail.EmailValidation(Email2);
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
    

