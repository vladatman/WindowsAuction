using Auction.States;
using AuctionProgram.Classes;
using AuctionProgram.Classes.Products;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AuctionProgram
{
    public partial class MainForm : Form
    {
        public DataBase dataBase;
        public Classes.Auction auction;
        public Bidder currentBidder;

        private bool isHidden = false;

        public MainForm()
        {
            InitializeComponent();
            lotGrid.Controls.Clear();

            dataBase = new DataBase();
            auction = new Classes.Auction(new WorkState(), dataBase.getBidders(), dataBase.getLots(this));

            foreach (Product lot in auction.lots)
            {
                lot.render();
                lotGrid.Controls.Add(lot);
            }

            this.carDatePicker.MinDate = DateTime.Now;
            this.telephoneDatePicker.MinDate = DateTime.Now;
            this.houseDateTimePicker.MinDate = DateTime.Now;

            this.FormClosing += MainForm_FormClosing;
            this.trayIcon.DoubleClick += TrayIcon_DoubleClick;
            this.buttonRefresh.Click += buttonRefresh_Click;
            this.disableBiddingCheckBox.CheckedChanged += disableBiddingCheckBox_CheckedChanged;
            this.User.SelectionChangeCommitted += User_SelectionChangeCommitted;
            this.carConfirmButton.Click += CarConfirmButton_Click;
            this.telephoneConfirmButton.Click += TelephoneConfirmButton_Click;
            this.houseConfirmButton.Click += HouseConfirmButton_Click;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.bidderTableAdapter.Fill(this.auctionDataSet.Bidder);
            setCurrentBidder();
            countdownTimer.Tick += new EventHandler(CountdownTimer_Tick);
            countdownTimer.Start();

            dataBaseTimer.Tick += new EventHandler(DataBaseTimer_Tick);
            dataBaseTimer.Start();
        }

        void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (!disableBiddingCheckBox.Checked)
            {
                checkTime();
            }
            foreach (var lot in auction.lots)
            {
                TimeSpan remainingTime = lot.ExpTime - DateTime.Now;
                if (remainingTime.TotalSeconds > 0)
                {
                    lot.Controls.Find("timeLeft", true).FirstOrDefault().Text = string.Format("{0:D2}:{1:D2}:{2:D2}", (remainingTime.Days * 24) + remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds);
                }
                else
                {
                    lot.Controls.Find("timeLeft", true).FirstOrDefault().Text = "Sold!";
                }
            }
        }

        void DataBaseTimer_Tick(object sender, EventArgs e)
        {
            refresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && isHidden == false)
            {
                e.Cancel = true;
                this.Hide();
                isHidden = true;
            }
        }

        private void TrayIcon_DoubleClick(object Sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void refresh()
        {
            auction.bidders = dataBase.getBidders();
            auction.lots.AddRange(dataBase.getLots(this));

            foreach (var lot in auction.lots)
            {
                lot.setLastBid(dataBase.getLastBid(lot));
                lot.Controls.Find("money", true).FirstOrDefault().Text = "Last bid - " + dataBase.getLastBid(lot);
            }

            foreach (Product newLot in auction.lots)
            {
                bool isPresent = false;

                foreach (Product item in lotGrid.Controls)
                {
                    if (item.Id == newLot.Id)
                    {
                        isPresent = true;
                        break;
                    }
                }

                if (!isPresent)
                {
                    newLot.render();
                    lotGrid.Controls.Add(newLot);
                }
            }
        }

        private void checkBiddersList()
        {
            this.bidderTableAdapter.Fill(this.auctionDataSet.Bidder);
        }

        private void buttonRefresh_Click(object Sender, EventArgs e)
        {
            refresh();
            checkBiddersList();
        }

        private void checkTime()
        {
            DateTime sixPM = DateTime.Today.AddHours(24);
            if (DateTime.Now > sixPM)
            {
                auction.disable();
            }
            else
            {
                auction.enable();
            }
        }

        private void disableBiddingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disableBiddingCheckBox.Checked)
            {
                auction.disable();
            }
            else
            {
                auction.enable();
            }
        }

        private void setCurrentBidder()
        {
            currentBidder = auction.bidders.FirstOrDefault(bidder => bidder.Name == User.Text);
            if (currentBidder != null)
            {
                foreach (Product lot in auction.lots)
                {
                    bool isBidderTrackingLot = lot.Observers.Any(observer => observer is Bidder && ((Bidder)observer).Id == currentBidder.Id);

                    lot.IsTracking = isBidderTrackingLot;
                    lot.checkTrack();
                }
            }
        }

        private void User_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setCurrentBidder();
        }

        private void CarConfirmButton_Click(object sender, EventArgs e)
        {
            string brand = carBrandTextBox.Text;
            string model = carModelTextBox.Text;
            string color = carColorTextBox.Text;
            float totalKm = float.Parse(carTolalKmTextBox.Text);
            DateTime dateTime = carDatePicker.Value.Date + carTimePicker.Value.TimeOfDay;

            if (!string.IsNullOrWhiteSpace(brand) && !string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(color))
            {
                dataBase.addCar(brand, model, color, totalKm, dateTime);
            }
        }

        private void TelephoneConfirmButton_Click(object sender, EventArgs e)
        {
            string brand = telephoneBrandTextBox.Text;
            string model = telephoneModelTextBox.Text;
            string color = telephoneColorTextBox.Text;
            int batteryPower = int.Parse(telephoneBatteryPowerTextBox.Text);
            DateTime dateTime = telephoneDatePicker.Value.Date + telephoneTimePicker.Value.TimeOfDay;

            if (!string.IsNullOrWhiteSpace(brand) && !string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(color))
            {
                dataBase.addTelephone(brand, model, color, batteryPower, dateTime);
            }
        }

        private void HouseConfirmButton_Click(object sender, EventArgs e)
        {
            string location = houseLocationTextBox.Text;
            string style = houseStyleTextBox.Text;
            DateTime builtDate = houseBuiltDatePicker.Value.Date;
            DateTime dateTime = houseDateTimePicker.Value.Date + houseTimePicker.Value.TimeOfDay;

            if (!string.IsNullOrWhiteSpace(location) && !string.IsNullOrWhiteSpace(style))
            {
                dataBase.addHouse(location, style, builtDate, dateTime);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
