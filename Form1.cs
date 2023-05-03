using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Pizza_Project
{
    public partial class frmMain : Form
    {

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }



        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {

                lblCrustType.Text = "Thin Crust";
            } else
            {
                lblCrustType.Text = "Thick Crust";

            }
        }

        void UpdateToppings()
        {

            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings += "Extra Chees";

            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";

            }
            if (chkMushrooms.Checked)
            {
                sToppings += ", Mashrooms";

            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";

            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";

            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";

            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1,sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;


        }
      
        
        void UpdateWhereToEat()
        {

            if (rbEatIn.Checked)
            {

                lblWhereToEat.Text = rbEatIn.Text;
            } else
            {
                lblWhereToEat.Text = rbTakeOut.Text;
            }

        }
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
          
            UpdateToppings();   
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else 
                return Convert.ToSingle(rbLarge.Tag);   
            
        }

        float GetSelectedCrustSize()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else 
                return Convert.ToSingle(rbThickCrust.Tag);



        }

        float CalculateToppingPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            return ToppingsTotalPrice;
        }

        float CalculateTotalPrice()
        {

            return GetSelectedSizePrice() + CalculateToppingPrice() + GetSelectedCrustSize();
        }


        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString(); 
        }



        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            lblTotalPrice.Text = "$" + 0;

    }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();


        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrust();
          
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
          
          
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void btnOrderButton_Click(object sender, EventArgs e)
        {
            if (

            MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK
                )
            {

                MessageBox.Show("Order Placed Successfully" , "Success" , MessageBoxButtons.OK,MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }
    }
}
