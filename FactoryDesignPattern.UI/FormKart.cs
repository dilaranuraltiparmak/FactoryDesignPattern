using FactoryDesignPattern.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDesignPattern.UI
{
    public partial class FormKart : Form
    {
        public FormKart()
        {
            InitializeComponent();
        }

        private void btnPlatinum_Click(object sender, EventArgs e)
        {
            ICreditCard cardDetails = (ICreditCard)CreditCardFactory.GetCreditCard("Platinum");
      
            if (cardDetails != null)
            {
                MessageBox.Show("CardType : " + cardDetails.GetCardType() +" "+
                    "AnnualCharge :" + cardDetails.GetAnnualCharge());
             
            }
            else
            {
                MessageBox.Show("Invalid Card Type");
            }
         
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            ICreditCard cardDetails = (ICreditCard)CreditCardFactory.GetCreditCard("MoneyBack");

            if (cardDetails != null)
            {
                MessageBox.Show("CardType : " + cardDetails.GetCardType() + " " +
                    "AnnualCharge :" + cardDetails.GetAnnualCharge());

            }
            else
            {
                MessageBox.Show("Invalid Card Type");
            }
        }

        private void btnTitanium_Click(object sender, EventArgs e)
        {
            ICreditCard cardDetails = (ICreditCard)CreditCardFactory.GetCreditCard("Titanium");

            if (cardDetails != null)
            {
                MessageBox.Show("CardType : " + cardDetails.GetCardType() + " " +
                    "AnnualCharge :" + cardDetails.GetAnnualCharge());

            }
            else
            {
                MessageBox.Show("Invalid Card Type");
            }
        }

    }
    }
    

