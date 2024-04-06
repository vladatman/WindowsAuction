using AuctionProgram.Classes;
using AuctionProgram.Classes.Products;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace AuctionProgram
{
    public partial class BidForm : Form
    {
        private MainForm mainForm;
        private Product lot;

        public BidForm(MainForm mainForm, Product lot)
        {
            InitializeComponent();
            this.FormClosing += BidForm_FormClosing;
            this.confirmButton.Click += confirmButton_Click;
            this.cancelButton.Click += cancelButton_Click;
            this.bidAmount.KeyPress += bidAmount_KeyPress;
            this.mainForm = mainForm;
            this.lot = lot;
        }

        private void bidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the confirm() method
                confirm(e);
            }

            char ch = e.KeyChar;

            if (!char.IsNumber(ch) && ch != 8 && ch != 46 && ch != 13)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
            {
                e.Handled = true;
                MessageBox.Show("Only accept digital character or letter.");
            }

        }

        private void BidForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent disposal of DetailForm when closing
            e.Cancel = true; // Cancel the closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var closeArgs = e as CancelEventArgs;
            if (closeArgs != null)
            {
                closeArgs.Cancel = true; // Cancel the closing event
            }
            this.Hide(); // Hide the form instead of closing it
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            confirm(e);
        }

        private void confirm(EventArgs e)
        {
            if (Convert.ToInt32(this.bidAmount.Text) > lot.LastBid)
            {
                Bidder bidderObj = mainForm.auction.bidders.FirstOrDefault(bidder => bidder.Name == mainForm.User.Text);
                mainForm.dataBase.makeBid(bidderObj, lot, Convert.ToInt32(this.bidAmount.Text));
                var closeArgs = e as CancelEventArgs;
                if (closeArgs != null)
                {
                    closeArgs.Cancel = true; // Cancel the closing event
                }
                this.Hide(); // Hide the form instead of closing it
            }
            else
            {
                MessageBox.Show("Bid must be greater than current one." +
                    "\nCurrent bid is " + lot.LastBid);
            }
        }
    }
}
