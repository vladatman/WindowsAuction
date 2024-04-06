using System.Windows.Forms;

namespace AuctionProgram
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
            this.FormClosing += DetailForm_FormClosing;
        }

        private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent disposal of DetailForm when closing
            e.Cancel = true; // Cancel the closing event
            this.Hide(); // Hide the form instead of closing it
        }
    }
}
