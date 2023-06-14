using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
/*
Exercise 3: Creating a BankAccount Class
Create a BankAccount class with the following properties:

AccountNumber(string)
OwnerName(string)
Balance(double)
Implement the default constructor and a parameterized constructor that takes values for all the properties.
Additionally, implement methods to deposit and withdraw funds from the account.
*/
namespace c_sharp_oop
{
    public class BankAccount
    {
        public string AccountNumber;
        public string OwnerName;
        public double Balance;

        public BankAccount(string AccountNumber, string OwnerName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.OwnerName = OwnerName;
           this.Balance = Balance;
            displayData();
            depositAndWithdraw();

        }

        public void displayData()
        {
            WriteLine("Account Number  is " + this.AccountNumber);
            WriteLine("Owner Name name is " + this.OwnerName);
            WriteLine("Account " + this.AccountNumber + "  have  " + this.Balance);
          
        }

        public void depositAndWithdraw()
        {
            string str1;
            
            //{ "deposit", "withdraw" };
           
            WriteLine("choos the operation you want to do(deposit or withdraw)");
            str1 =Convert.ToString(ReadLine());
           int deposit, withdraw;
            switch (str1)
            {
                case "deposit":

                    WriteLine("enter amount to deposit");
                    deposit=int.Parse(ReadLine());
                    this.Balance = this.Balance + deposit;
                    WriteLine("Account " + this.AccountNumber + "  have  " + this.Balance);

                    break;
                case "withdraw":

                    WriteLine("enter amount to withdraw");
                    deposit = int.Parse(ReadLine());
                    this.Balance = this.Balance - deposit;
                    WriteLine("Account " + this.AccountNumber + "  have  " + this.Balance);
                    break;

                default:
                    WriteLine("you have entered invalid input");
                    break;
            }


        }



    }
}
