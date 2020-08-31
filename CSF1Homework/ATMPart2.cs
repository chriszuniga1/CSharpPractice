using System;

namespace CSF1Homework
{
    class ATMPart2
    {
        static void Main(string[] args)
        {
            #region Define Variables

            //Variables for program: 
            const string userAccountNbr = "123456", userPinNbr = "4242";

            int deposit;    //  The amount the user will deposit
            int withdrawal; //  The amount the user will withdraw
            string selection, userPin;
            string userAccount = "";
            #endregion

            #region Get Account
            //--------------------------------------------------------
            //  Get the account number
            //--------------------------------------------------------

            bool finished = false;  //asume the user is going to type the wrong thing
            int attempts = 0;       //This is used to track number of tries

            do
            {
                Console.WriteLine("Please enter your account number");
                userAccount = Console.ReadLine();
                attempts++;             //Keeping track of number of times tried-like a running total
                if (userAccount == userAccountNbr)
                {
                    finished = true;    //User entered account correctly-Moves on to request pin
                }
                else if (attempts > 2)  //User limited to 3 attempts at entering account number
                {
                    finished = true;    //User tried and failed more than 3 times
                    Console.WriteLine("Number of attempts exceeded");
                }
                else
                {
                    Console.WriteLine("Account not recgonized, please try again.");
                }
            } while (finished == false);        //Do all above until user enters info correctly or exceeds number of attempts
            #endregion

            if (userAccount == userAccountNbr)  //If user entered account number correctly do the following
            {

                //Get the pin number
                

                #region Get Pin
                attempts = 0;

                do
                {
                    Console.WriteLine("Please enter your pin");
                    userPin = Console.ReadLine();
                    attempts++;
                    if (userPin != userPinNbr && attempts > 2)
                    {
                       
                        Console.WriteLine("Number of attempts exceeded");
                    }
                    else if (userPin != userPinNbr)
                    {
                        Console.WriteLine("Pin not recgonized, please try again.");

                    }
                } while (userPin != userPinNbr && attempts < 3);
                #endregion

                if (userPin == userPinNbr)
                {
                    #region Show and Do Menu
                    //Show and do Menu
                    finished = false;
                    do
                    {
                        Console.WriteLine("Please Select A Number From The Following Options:");
                        Console.WriteLine("1) Make a Deposit");
                        Console.WriteLine("2) Make a Withdrawal");
                        Console.WriteLine("3) Exit Menu");
                        selection = Console.ReadLine();
                        switch (selection)
                        {
                            case "1":
                                Console.Write("Enter Deposit Amount (Whole numbers only): $");
                                deposit = int.Parse(Console.ReadLine());
                                Console.WriteLine("You have deposited deposited ${0} into you account {1}.", deposit, userAccountNbr);

                                Console.Write("Would you like to proceed with another transaction?\nSelect 1 for YES\nSelect 2 for No\n");
                                selection = Console.ReadLine();
                                if (selection == "2")
                                {
                                    finished = true;
                                }

                                break;

                            case "2":
                                Console.Write("Enter Withdrawal Amount(Whole numbers only): $");
                                withdrawal = int.Parse(Console.ReadLine());
                                Console.WriteLine($"You have withdrawn ${withdrawal} from your account {userAccountNbr}.");

                                Console.Write("Would you like to proceed with another transaction?\nSelect 1 for YES\nSelect 2 for No\n");
                                selection = Console.ReadLine();
                                if (selection == "2")
                                {
                                    finished = true;
                                }

                                break;

                            case "3":
                                Console.WriteLine("Thank you for banking with us today.");
                                finished = true;
                                break;

                            default:
                                Console.WriteLine("Response not valid. Please try again.");
                                break;


                        }

                    } while (finished == false);

                    #endregion
                }


            }

        }//end Main()
    }//end Class
}//end Namespace
