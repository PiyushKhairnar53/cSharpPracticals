
namespace BankApplication
{
    internal class BankOperations:BankDetails
    {
        public int totalAccountBalance = 0;
        int depositAmount;
        int withdrawAmount;

        public class InvalidAmountException : Exception
        {
            public InvalidAmountException(string message) 
            {
                Console.WriteLine("\n"+message);
            }
        }

        public void UpdateBalacne() 
        {
            string? input;
            Console.WriteLine("\nDo you want to deposit amount(y/yes or n/no) : ");
            input = Console.ReadLine();
            input.ToLower();

            if (input == "y" || input == "yes") 
            {
                DepositAmount();
            }

            Console.WriteLine("Do you want to withdraw amount(y/yes or n/no) : ");
            input = Console.ReadLine();
            input!.ToLower();

            if (input == "y" || input == "yes")
            {
                WithdrawAmount();
            }
        }

        public void DepositAmount() 
        {
            bool validAmount = false;
            do
            {
                Console.WriteLine("Please enter The amount of money to deposit : ");
                string? input = Console.ReadLine();  
                bool inputIsNumber = Int32.TryParse(input, out depositAmount);

                try
                {
                    if (inputIsNumber && depositAmount > 0 && depositAmount <= 100000)
                    {
                        totalAccountBalance = totalAccountBalance + depositAmount;
                        validAmount = true;
                        break;
                    }
                    else
                    {
                        validAmount = false;
                        if (depositAmount == 0)
                        {
                            throw new InvalidAmountException("\nDeposit Amount should be greater than 0");
                        }
                        else if (depositAmount > 100000)
                        {
                            throw new InvalidAmountException("\nDeposit Amount should be less than 100000");
                        }
                        else
                            throw new InvalidAmountException("\nDeposit Amount you have entered is invalid..");

                    }
                }
                catch (InvalidAmountException exception)
                {
                    Console.WriteLine(exception);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
                finally 
                {
                    Console.WriteLine("Account balance : " + totalAccountBalance);
                }
            } while (validAmount == false);
    }

        public void WithdrawAmount() 
        {
            bool validAmount = false;
            do
            {
                Console.WriteLine("Please enter The amount of money to withdraw : ");
                string? input = Console.ReadLine();
                bool inputIsNumber = Int32.TryParse(input, out withdrawAmount);

                try
                {
                    if (inputIsNumber && withdrawAmount > 0 && withdrawAmount < 50000)
                    {
                        if (withdrawAmount <= totalAccountBalance)
                        {
                            totalAccountBalance = totalAccountBalance - withdrawAmount;
                            validAmount = true;
                            break;
                        }
                        else 
                        {
                            throw new InvalidAmountException("Your account balance is low..");
                        }
                    }
                    else
                    {
                        validAmount = false;

                        if (withdrawAmount == 0)
                        {
                            throw new InvalidAmountException("\nWithdraw Amount should be greater than 0");
                        }
                        else if (withdrawAmount > 50000)
                        {
                            throw new InvalidAmountException("\nDaily withdraw limit is 50000");
                        }
                        else
                            throw new InvalidAmountException("\nThe amount you want to withdraw is invalid");
                    }
                }
                catch (InvalidAmountException exception)
                {
                    Console.WriteLine(exception);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
                finally
                {
                    Console.WriteLine("Account balance : " + totalAccountBalance);
                }

            } while (validAmount == false);
        }
    }
}
