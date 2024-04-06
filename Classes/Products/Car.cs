using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuctionProgram.Classes.Products
{
    class Car : Product
    {


        private string brand;
        private string model;
        private string color;
        private float total_km;


        //GUI
        private int shadowDepth = 5;
        public PictureBox trackingIcon;
        public PictureBox pictureBox;
        public Label label;
        public Label timer;
        public Label money;
        public Button detailsButton;
        BidForm bidForm;
        DetailForm detailForm;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public float Total_km { get => total_km; set => total_km = value; }

        public Car(int id, string brand, string model, string color, float total_km, int money, DateTime expTime, MainForm mainForm)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Total_km = total_km;
            this.LastBid = money;
            this.ExpTime = expTime;

            this.trackingIcon = new PictureBox();
            this.detailForm = new DetailForm();
            this.pictureBox = new PictureBox();
            this.label = new Label();
            this.timer = new Label();
            this.money = new Label();
            this.buyButton = new Button();
            this.detailsButton = new Button();
            this.bidForm = new BidForm(mainForm, this);
            this.Observers = new List<IObserver>();
            trackingIcon.Image = Properties.Resources.eyes_closed;

            render();
        }

        public override void render()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.Padding = new Padding(shadowDepth);

            this.Size = new Size(180, 270);

            trackingIcon.Size = new Size(24, 24);
            trackingIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(trackingIcon);
            trackingIcon.Location = new Point((this.Width - trackingIcon.Width - 5), 5);
            trackingIcon.Click -= trackingIcon_Click;
            trackingIcon.Click += trackingIcon_Click;

            pictureBox.Size = new Size(160, 165);
            pictureBox.Image = Properties.Resources.car;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
            pictureBox.Location = new Point((this.Width - pictureBox.Width) / 2, 5);

            timer.Name = "timeLeft";
            timer.Text = "00:00:00";
            timer.AutoSize = true;
            this.Controls.Add(timer);
            timer.Location = new Point((this.Width - timer.Width) / 2, 180);

            label.Text = Model;
            label.AutoSize = true;
            this.Controls.Add(label);
            label.Location = new Point((this.Width - label.Width) / 2, 200);

            money.Name = "money";
            money.Text = "Last bid - " + this.LastBid;
            money.AutoSize = true;
            this.Controls.Add(money);
            money.Location = new Point((this.Width - money.Width) / 2, 220);

            buyButton.Text = "Bid";
            this.Controls.Add(buyButton);
            buyButton.Location = new Point(10, 240);
            buyButton.Click += (sender, e) =>
            {
                bid();
            };

            detailsButton.Text = "Details";
            this.Controls.Add(detailsButton);
            detailsButton.Location = new Point(95, 240);
            detailsButton.Click += (sender, e) =>
            {
                showInfo();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var shadowColor = System.Drawing.Color.FromArgb(100, System.Drawing.Color.LightBlue);
            e.Graphics.FillRectangle(new SolidBrush(shadowColor), new Rectangle(0, 0, this.Width, this.Height));

            var clientRect = new Rectangle(shadowDepth, shadowDepth, this.Width - 2 * shadowDepth, this.Height - 2 * shadowDepth);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), clientRect);
        }

        public override void bid()
        {
            bidForm.Parent = getMainForm();
            bidForm.Text = "Bid " + this.Model;
            bidForm.bidAmount.Text = this.LastBid.ToString();
            bidForm.Show();
        }

        public override void showInfo()
        {
            detailForm.Text = "Details " + this.Model;

            detailForm.picture.Image = Properties.Resources.car;
            detailForm.picture.SizeMode = PictureBoxSizeMode.StretchImage;

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Brand:          {0}", this.Brand).AppendLine()
              .AppendFormat("Model:          {0}", this.Model).AppendLine()
              .AppendFormat("Color:          {0}", this.Color).AppendLine()
              .AppendFormat("Total KM:       {0}", this.Total_km);
            detailForm.detailsLabel.Text = sb.ToString();
            detailForm.detailsLabel.Font = new Font("Courier New", 10f);
            detailForm.detailsLabel.AutoSize = true;
            detailForm.detailsLabel.Location = new Point((this.Width - pictureBox.Width) / 2, 200);

            detailForm.Show();
        }

        public void attach(IObserver bidder)
        {
            this.Observers.Add(bidder);
        }
        public void detach(IObserver bidder)
        {
            this.Observers.Remove(bidder);
        }
        public void notify()
        {
            foreach (IObserver bidder in this.Observers)
            {
                bidder.update(this);
            }
        }

        private void trackingIcon_Click(object sender, EventArgs e)
        {
            changeTrack();
        }

        public MainForm getMainForm()
        {
            MainForm mainForm = this.Parent as MainForm;
            if (mainForm != null)
            {
                // Now you can access MainForm's members and methods
                return mainForm;
            }
            return null;
        }

        public override void setLastBid(int money)
        {
            if (this.LastBid != money)
            {
                MainForm mainForm = this.Parent.Parent.Parent.Parent as MainForm;
                this.LastBid = money;
                this.money.Text = "Last bid - " + LastBid;
                if (Observers.Any(observer => (observer as Bidder)?.Id == mainForm.currentBidder.Id))
                {
                    this.notify();
                }
            }
        }

        public override void changeTrack()
        {
            MainForm mainForm = this.Parent.Parent.Parent.Parent as MainForm;

            if (IsTracking)
            {
                Bidder bidderObj = mainForm.currentBidder;
                this.detach(bidderObj);
                trackingIcon.Image = Properties.Resources.eyes_closed;
                IsTracking = false;
            }
            else
            {
                Bidder bidderObj = mainForm.currentBidder;
                this.attach(bidderObj);
                trackingIcon.Image = Properties.Resources.eyes_open;
                IsTracking = true;
            }
        }

        public override void checkTrack()
        {
            MainForm mainForm = this.Parent.Parent.Parent.Parent as MainForm;

            if (IsTracking)
            {
                trackingIcon.Image = Properties.Resources.eyes_open;
            }
            else
            {
                trackingIcon.Image = Properties.Resources.eyes_closed;
            }
        }
    }
}
