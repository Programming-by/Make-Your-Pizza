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
        public frmMain()
        {
            InitializeComponent();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
         

            if (chkMushrooms.Checked)
            {
                if (labelCurrentToppings.Text == "No Toppings")
                {
                    labelCurrentToppings.Text = "";

                }


                labelCurrentToppings.Text += chkMushrooms.Text;
            } 

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderButton.Enabled = true;
        

    }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                labelCurrentSize.Text = rbSmall.Text;


            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                labelCurrentSize.Text = rbMedium.Text;


            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                labelCurrentSize.Text = rbLarge.Text;

            }
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {

                labelCurrentCrustType.Text = rbThin.Text;
            }
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {

                labelCurrentCrustType.Text = rbThick.Text;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {

                labelCurrentWhereToEat.Text = rbEatIn.Text;
            }
          
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {

                labelCurrentWhereToEat.Text = rbTakeOut.Text;
            }

        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraChees.Checked == true) {

                if (labelCurrentToppings.Text == "No Toppings")
                {
                    labelCurrentToppings.Text = "";
                }

                labelCurrentToppings.Text += chkExtraChees.Text;
            }
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                if (labelCurrentToppings.Text == "No Toppings")
                {
                    labelCurrentToppings.Text = "";
                }

                labelCurrentToppings.Text += chkTomatoes.Text;
            }
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                if (labelCurrentToppings.Text == "No Toppings")
                {
                    labelCurrentToppings.Text = "";
                }

                labelCurrentToppings.Text += chkOnion.Text;
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {

                if (labelCurrentToppings.Text == "No Toppings")
                {
                    labelCurrentToppings.Text = "";
                }

                labelCurrentToppings.Text += chkOlives.Text;
            }
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPeppers.Checked)
            {
                if (labelCurrentToppings.Text == "No Toppings")
                {
                    labelCurrentToppings.Text = "";
                }

                labelCurrentToppings.Text += chkGreenPeppers.Text;
            }
        }

        private void btnOrderButton_Click(object sender, EventArgs e)
        {
            if (

            MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK
                )
            {
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderButton.Enabled = false;
            }
        }
    }
}
