using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        }

        public displayData()
        {

        }



    }
}
