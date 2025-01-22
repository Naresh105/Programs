using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using STATEBANK__OF_INDIA;

namespace STATEBANK__OF_INDIA
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string accountNumber = "";
            string accountHolderName = "";
            decimal balance = 0;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;   
            while (true)
            {
                Console.WriteLine("\t\t\t\t Bank Account System");
                Console.WriteLine("\t\t\t\t1. Enter User Details");
                Console.WriteLine("\t\t\t\t2. Display User Detail");
                Console.WriteLine("\t\t\t\t3. Check Balance");
                Console.WriteLine("\t\t\t\t4. Add Amount");
                Console.WriteLine("\t\t\t\t5. Withdrawal");
                Console.WriteLine("\t\t\t\t6. Exit");
                Console.Write("\t\t\t\tChoose an option:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        EnterUserDetails(ref accountNumber, ref accountHolderName, ref balance);
                        break;
                    case 2:
                        DisplayUserDetails(accountNumber, accountHolderName, balance);
                        break;
                    case 3:
                        CheckBalance(balance);
                        break;
                    case 4:
                        AddAmount(ref balance);
                        break;
                    case 5:
                        Withdrawal(ref balance);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

       
        static void EnterUserDetails(ref string accountNumber, ref string accountHolderName, ref decimal balance)
        {
            Console.Write("Enter account number: ");
            accountNumber = Console.ReadLine();

            Console.Write("Enter account holder name: ");
            accountHolderName = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            balance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("User details entered successfully.");
        }

        
        static void DisplayUserDetails(string accountNumber, string accountHolderName, decimal balance)
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Available Balance: " + balance);
        }

        
        static void CheckBalance(decimal balance)
        {
            Console.WriteLine("Available Balance: " + balance);
        }

      
        static void AddAmount(ref decimal balance)
        {
            Console.Write("Enter amount to add: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            balance =balance+ amount;
            Console.WriteLine("Amount added successfully.");
        }

     
        static void Withdrawal(ref decimal balance)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance =balance-amount;
                Console.WriteLine("Amount withdrawn successfully.");
            }
        }
    }
}
