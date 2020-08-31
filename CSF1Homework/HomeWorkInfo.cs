using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class HomeWorkInfo
    {
        static void Main(string[] args)
        {
            /*
             * ATM Instructions:
            1. Ask the user to enter an account number for their account
                a. Continue to ask the user for their account number until they get it right (the correct account number will be hard coded in your code. See the Login section for an example). Optionally, consider locking them out after a certain number of failed attempts. 

            2. Once they get the correct account number, ask them for a pin number (you can use the additional Login functionality as a reference). Just as you did for their account number, continue to prompt the user for their pin until they get it correct. (The correct value will be hard coded just as it was for the account number) 

            3. Once the user has successfully given their account and pin numbers, prompt the user with a menu and ask them if they want to do a deposit, a withdrawal, or exit the application. 

            4. If they choose to do a deposit, ask them for the amount to deposit, and display the amount deposited. 
                a. Ex. “$500.00 has been deposited into account number 12345” 

            5. If they choose to withdraw money, ask them for the amount to withdraw and display the amount being withdrawn. 
                a. Ex. “$500.00 has been withdrawn from account number 12345” 

            6. After each transaction (deposit or withdrawal) ask the user if they want to do another deposit/withdrawal, or exit the application. 

            7. When the user exits the application, thank them for their business. 
 
        Additional Optional Features: 
        Keep a running total of the account balance, assuming that the account starts at $0. 
        Every time the user makes a deposit to – or withdraw from – the account, the balance should be updated and displayed. 
        Add a feature for the user to make a balance request that will display their current balance (without needing to make a deposit or withdrawal). 
         */


            int atm = 100000, deposit, userTry, withdrawal, balance, pin1, pin2, pin3, userAccount, selection, count = 0;


            string userName = "Christina Zuniga";
      

            const int pin = 4242;
            const int accountNumber = 123456;

            bool authenticated = false;
            bool locked = false;

            bool repeat = true;
            do
            {

                do
                {
                    Console.WriteLine("Enter your Account Number.");
                    userAccount = int.Parse(Console.ReadLine());
                    count++;
                } while ((userAccount != accountNumber) && (count !=3));

                if (count == 3)
                {
                    Console.WriteLine("Account not recgonized, please try again");
                }
                else
                {
                    Console.WriteLine("Account Accepted");
                }



                //Console.Write("Please enter your account number: ");
                //userAccount = int.Parse(Console.ReadLine());
                //if (userAccount == accountNumber)
                //{
                //    Console.WriteLine("Welcome Christina Zuniga");
                //}
                //else
                //{
                //    Console.WriteLine("Account number not recognized, please try again.");
                //}


                Console.WriteLine("Please enter your Pin Number ");
                pin1 = int.Parse(Console.ReadLine());
                if (pin1 == pin)
                {
                    Console.WriteLine("How many we assit you today?");
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

                        Console.Write("Would you like to proceed with another transaction?\nSelect 1 for YES\nSelect 2 for No\n");


                        break;

                    case 2:
                        Console.Write("Enter Withdrawal Amount(Whole numbers only): $");
                        withdrawal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You have withdrawn ${withdrawal} from your account {accountNumber}.");

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
