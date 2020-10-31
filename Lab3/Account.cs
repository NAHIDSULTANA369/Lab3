using System;
namespace Lab3
{
    public class Account
    {
        string accName;
        string acId;
        int balance;

        public string getAccName()
        {
            return accName;
        }
        public string getAcId()
        {
            return acId;
        }
        public int getBalance()
        {
            return balance;
        }
        public void setAccName(String AccName)
        {
            accName = AccName;
        }
        public void setAcId(String AcId)
        {
            acId = AcId;
        }
        public void setBalance(int Balance)
        {
            balance = Balance;
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
        }
    }
}
