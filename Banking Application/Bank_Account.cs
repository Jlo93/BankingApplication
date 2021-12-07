using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    // The abstract keyword enables classes and members to be created that are "incomplete"
    // and must be implemented in a derived class.
    
    // An abstract class cannot be instantiated(When a new object is created using a new keyword)
    // Its purpose is to give common defination of a base class that multiple derived classes can
    // share.  
    public abstract class Bank_Account
    {

        public String accountNo;
        public String name;
        public String address_line_1;
        public String address_line_2;
        public String address_line_3;
        public String town;
        public double balance;

        public Bank_Account()
        {
        }

        public Bank_Account(String name, String address_line_1, String address_line_2, String address_line_3, String town, double balance)
        {
            this.accountNo = System.Guid.NewGuid().ToString();
            this.name = name;
            this.address_line_1 = address_line_1;
            this.address_line_2 = address_line_2;
            this.address_line_3 = address_line_3;
            this.town = town;
            this.balance = balance;
        }

        public void lodge(double amountIn)
        {

            balance += amountIn;

        }

        public abstract bool withdraw(double amountToWithdraw);

        public abstract double getAvailableFunds();

        public override String ToString()
        {

            return "\nAccount No: " + accountNo + "\n" +
            "Name: " + name + "\n" +
            "Address Line 1: " + address_line_1 + "\n" +
            "Address Line 2: " + address_line_2 + "\n" +
            "Address Line 3: " + address_line_3 + "\n" +
            "Town: " + town + "\n" +
            "Balance: " + balance + "\n";

    }

    }
}
