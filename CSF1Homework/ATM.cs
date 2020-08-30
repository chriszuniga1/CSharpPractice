using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            int atm = 100000, deposit, withdrawal, balance, pin1, pin2, userAccount, userResponse, selection, maxAttempts = 3;
            string userName = "Christina Zuniga";
            const int pin = 4242;
            const int accountNumber = 123456;

            bool repeat = true;
            do
            {
                Console.Write("Please enter your account number: ");
                userAccount = int.Parse(Console.ReadLine());
                if (userAccount == accountNumber)
                {
                    Console.WriteLine("Welcome Christina Zuniga");
                }
                else if (userAccount != accountNumber)
                {
                    Console.WriteLine("Account number not recognized, please try again.");
                }

                Console.WriteLine("Please enter your Pin Number ");
                pin1 = int.Parse(Console.ReadLine());
                if (pin1 == pin)
                {
                    Console.WriteLine("How many we assit you today?");
                }
                else if (pin1 == pin)
                {
                    Console.WriteLine("Pin number not recognized please try again.");
                }

                Console.WriteLine("Please Select A Number From The Following Options:");
                Console.WriteLine("1) Make a Deposit");
                Console.WriteLine("2) Make a Withdrawal");
                Console.WriteLine("3) Exit Menu");
                selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.Write("Enter Deposit Amount (Whole numbers only): $");
                        deposit = int.Parse(Console.ReadLine());
                        Console.WriteLine("You have deposited deposited ${0} into you account {1}.", deposit, accountNumber);

                        Console.Write("Would you like to proceed with another transaction? Y/N");
                        userResponse = int.Parse(Console.ReadLine());

                        break;

                    case 2:
                        Console.Write("Enter Withdrawal Amount(Whole numbers only): $");
                        withdrawal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You have withdrawn ${withdrawal} from your account {accountNumber}.");

                        Console.Write("Would you like to proceed with another transaction? Y/N");

                        break;

                    case 3:
                        Console.WriteLine("Thank you for banking with us today.");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Response not valid. Please try again.");
                        break;


                }



                } while (repeat);



        }//end Main()
    }//end Class
}//end NameSpace
