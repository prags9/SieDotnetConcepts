using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLibrary
{
    public class Account
    {
        public event EventHandler<string> TransactionApprovedEvent;
        public event EventHandler<decimal> OverdraftEvent;

        public string AccountName { get; set; }
        public decimal Balance { get; private set; }
        private List<string> _transactions = new List<string>();

        public IReadOnlyList<string> Transactions
        {
            get{ return _transactions.AsReadOnly(); }
        }

        public bool AddDeposit(string depositName, decimal amount)
        {
            _transactions.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
            Balance += amount;
            TransactionApprovedEvent?.Invoke(this, depositName);
            return true;
        }

        public bool MakePayment(string paymentName, decimal amount,Account backupAccount=null)
        {
            if (Balance >= amount)
            {
                _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                Balance -= amount;
                TransactionApprovedEvent?.Invoke(this, paymentName);
                return true;
            }
            else
            {
                if (backupAccount != null)
                {
                    if ((backupAccount.Balance + Balance) >= amount)
                    {
                        decimal amountNeeded = amount - Balance;
                        bool overdraftSucceeded = backupAccount.MakePayment("Overdraft protection", amountNeeded);
                        if (overdraftSucceeded == false)
                        {
                            return false;
                        }
                        AddDeposit("Overdraft protection deposit", amountNeeded);
                        _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                        Balance -= amount;
                        TransactionApprovedEvent?.Invoke(this, paymentName);
                        OverdraftEvent?.Invoke(this, amountNeeded);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
