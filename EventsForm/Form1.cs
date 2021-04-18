using EventsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsForm
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();

            LoadTestingData();
            WireUpForm(); 
        }

        private void LoadTestingData()
        {
            customer.Name = "Praggy P";
            customer.SavingsAccount = new Account();
            customer.CheckingAccount = new Account();

            customer.CheckingAccount.AccountName = "Praggy's checking account";
            customer.SavingsAccount.AccountName = "Praggy's saving account";

            customer.CheckingAccount.AddDeposit("Initial Balance", 155.34M);
            customer.SavingsAccount.AddDeposit("Initial Balance", 98.45M);
        }

        private void WireUpForm()
        {
            textBox1.Text = customer.Name;
            listBox1.DataSource = customer.CheckingAccount.Transactions;
            listBox2.DataSource = customer.SavingsAccount.Transactions;
            textBox2.Text = string.Format("{0:C2}",customer.CheckingAccount.Balance);
            textBox3.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);

            //gluing togther two things - I am firing off event and I am listening to it.
            customer.CheckingAccount.TransactionApprovedEvent += CheckingAccount_TransactionApprovedEvent;
            customer.SavingsAccount.TransactionApprovedEvent += SavingsAccount_TransactionApprovedEvent;

            customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, decimal e)
        {
            errorMsg.Text = $"You have an overdraft protection of {string.Format("{0:C2}",e )}";
            errorMsg.Visible = true;
        }

        private void SavingsAccount_TransactionApprovedEvent(object sender, string e)
        {
            listBox2.DataSource = null;
            listBox2.DataSource = customer.SavingsAccount.Transactions;
            textBox3.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void CheckingAccount_TransactionApprovedEvent(object sender, string e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = customer.CheckingAccount.Transactions;
            textBox2.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(customer);
            transaction.Show();
        }

       /* private void errorMessage_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }*/

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorMsg_TextChanged(object sender, EventArgs e)
        {
            errorMsg.Visible = false;
        }
    }
}
