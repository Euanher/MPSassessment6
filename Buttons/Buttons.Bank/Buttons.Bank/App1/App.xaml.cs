using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Banking;
using Banking.XF;



namespace BankingFunctions
{
public class CodeButtonClickPage : Banking.XF
{
  public CodeButtonClickPage()
{
 InitializeComponent ();
}
async void OnButtonClicked(object sender, EventArgs args)
{
await label.Deposits;
}
}
 public CodeButtonClickPage()
{
 InitializeComponent ();
}
async void OnButtonClicked(object sender, EventArgs args)
{
await label.Withdraw;
}
}
 public CodeButtonClickPage()
{
 InitializeComponent ();
}
async void OnButtonClicked(object sender, EventArgs args)
{
await label.Transactions;
}
}
        
    public class ButtonFunctions : Deposits
    {
        public class BankAccount
    {
        private static int LastAccountNumber = 6000;

        public int AccountNumber { get; set; }

        public decimal Balance
        {
            get
            {
                decimal tempBalance = 0;

                for(int count = 0; count < Transactions.Count;count++)
                {
                    Transaction transaction = Transactions[count];
                    tempBalance += transaction.Amount;
                }

                return tempBalance;
            }

        }
        public void DepositMoney(decimal amount, DateTime date, string description)
        {
            Transaction transaction = new Transaction(amount, date, description);

            Transactions.Add(transaction);
        }
     public class ButtonFunctions : Withdraw
{
public void WithdrawMoney(decimal amount, DateTime date, string description)
        {
            if (Balance - amount < 0)
                throw new InvalidOperationException("Insuffienct Funds");    

            Transaction transaction = new Transaction(-amount, date, description);

            Transactions.Add(transaction);
        }
}
public class ButtonFunctions : Transactions
{
public string GetTransactionHistory()
        {
            StringBuilder sb = new StringBuilder();

            foreach(var transaction in Transactions)
            {
                string lineItem = Balance + "   " + transaction.Amount + "   " + transaction.TransactionDate.ToString() + "   " + transaction.Description ;
                sb.AppendLine(lineItem);
            }

            return sb.ToString();
        }
    }
}
public static MaxLength(int args)
{
  var entry = new Entry { ... MaxLength = 10 };
    
}
public string CursorPosition()
{
 var entry = new Entry { Text = "Cursor position set" , CursorPosition = 5 };
}