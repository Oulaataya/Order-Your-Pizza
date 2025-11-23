using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {  InitializeComponent();
           
            
        }
        //Confirm Order Button
        private void btnorder_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order ?  ", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Thank You :)");
                btnorder.Enabled = false;
                gbtoppinrs.Enabled = false;
                gbwheretoeat.Enabled = false;
                gbcrusttype.Enabled = false;
                gbsize.Enabled = false;
            }

        }
        //Reset Button
        private void btnresetform_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure ??", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                btnorder.Enabled = true;
                gbtoppinrs.Enabled = true;
                gbwheretoeat.Enabled = true;
                gbcrusttype.Enabled = true;
                gbsize.Enabled = true;
                rbmeduim.Checked = true;
                rbeatin.Checked = true;
                chkchees.Checked = false;
                chkmushrooms.Checked = false;
                chkolives.Checked = false;
                chkonion.Checked = false;
                chktomatoes.Checked = false;
                chkgreenpeppers.Checked = false;
                lblCrustType.Text = "thin Crust";
                lblPriceTotal.Text = "$0";
                lblSize.Text = "Meduim";
                lblToppings.Text = "No Toppings...";
                lblWhereToEat.Text = "Eat In";

            }
        }

        //------------------------------------------------------------------------------------------------------
        //size
        void UpdateSize()
        {
            UpdatePrice();
            if (rbsmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbmeduim.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rblarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }
        //crust type
        void UpdateCrustType()
        {
            UpdatePrice();
            if (rbthin.Checked) { lblCrustType.Text = "Thin Crust"; }
            else { lblCrustType.Text = "Think Crust"; }
        }

        //where to eat
        void UpdateWhereToEat()
        {
            UpdatePrice();
            if (rbeatin.Checked) { lblWhereToEat.Text = "Eat In"; }
            else { lblWhereToEat.Text = "Take Out"; }
        }


        //Toppings
        void UpdateToppings()
        {
            UpdatePrice();
            string toppings = "";
            if (chkchees.Checked) { toppings += "Extra Chees"; }
            if (chkmushrooms.Checked) { toppings += ", Mushrooms"; }
            if (chkolives.Checked) { toppings += ", Olives"; }
            if (chkonion.Checked) { toppings += ", Onions"; }
            if (chktomatoes.Checked) { toppings += ", Tomatoes"; }
            if (chkgreenpeppers.Checked) { toppings += ", Green Peppers"; }
            if (toppings == "") toppings = "No Toppings ";
            else  if (toppings.Substring(0, 2) == ", ")
            {
                string toppings2 = toppings.Substring(2);
                lblToppings.Text = toppings2;
            }
            else
            {
                lblToppings.Text = toppings;
            }

        }
        //-------------------------------------------------------------------------------------------------------

        //total price
        void UpdatePrice()
        {
            int price = 0;
              price += getSizePrice() + getCrustPrice() + getToppingsPrice() + getWhereToEatPrice();
            lblPriceTotal.Text ="$"+ price.ToString();
        }

        //size price
        int getSizePrice()
        {
            
            if (rbsmall.Checked)
            {
                return  (Convert.ToInt32(rbsmall.Tag));
            }
            else if (rbmeduim.Checked)
            {
                return (Convert.ToInt32(rbmeduim.Tag));
            }
            else
            {
               return (Convert.ToInt32(rblarge.Tag));
            }
            
        }
        // crust price
        int getCrustPrice()
        {
            if (rbthin.Checked)
            {
                return Convert.ToInt32(rbthin.Tag);
            }
            else
            {
                return Convert.ToInt32(rbthink.Tag);
            }
        }
         // Where to eat 
            int getWhereToEatPrice()
            {
                if (rbeatin.Checked)
                {
                    return Convert.ToInt32(rbeatin.Tag);
                }
                else return Convert.ToInt32(rbtakeout.Tag);
            }
       
        // toppings price
        int getToppingsPrice()
            {
                int price = 0;
            if(chkchees.Checked) { price += Convert.ToInt32(chkchees.Tag); }
            if (chktomatoes.Checked) { price += Convert.ToInt32(chktomatoes.Tag); }
            if (chkmushrooms.Checked) { price += Convert.ToInt32(chkmushrooms.Tag); }
            if (chkolives.Checked) { price += Convert.ToInt32(chkolives.Tag); }
            if (chkonion.Checked) { price += Convert.ToInt32(chkonion.Tag); }
            if (chkgreenpeppers.Checked) { price += Convert.ToInt32(chkgreenpeppers.Tag); }
            return price;

            }

        //
        void setDefualt()
        {
            lblCrustType.Text = "thin Crust";
            lblPriceTotal.Text = "$0";
            lblSize.Text = "Meduim";
            lblToppings.Text = "No Toppings...";
            lblWhereToEat.Text = "Eat In";


            rbsmall.Checked = true;
            rbmeduim.Checked = false;
            rblarge.Checked = false;

            rbthin.Checked = true;
            rbthink.Checked = false;

            rbeatin.Checked = true;
            rbtakeout.Checked = false;

            chkchees.Checked = false;
            chkmushrooms.Checked = false;
            chkolives.Checked = false;
            chkonion.Checked = false;
            chktomatoes.Checked = false;
            chkgreenpeppers.Checked = false;
        }

        //-------------------------------------------------------------------------------------------
      //call function
         
        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
           
            UpdateSize();
        }

        private void rbmeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbthink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void rbtakeout_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkonion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkolives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chktomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkchees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkgreenpeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkmushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            setDefualt();
        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }
    }
}
