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
    public partial class Transaction : Form
    {
        private Customer _customer;
        public Transaction(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            textBox2.Text = _customer.Name;
           
            _customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, decimal e)
        {
            errorMsg.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool paymentResult = _customer.CheckingAccount.MakePayment("Credit card purchase", numericUpDown1.Value,_customer.SavingsAccount);
            numericUpDown1.Value = 0;
        }

        private void errorMsg_TextChanged(object sender, EventArgs e)
        {
            //errorMsg.Visible = false;
        }
    }
}
