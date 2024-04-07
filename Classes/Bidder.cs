using AuctionProgram.Classes.Lots;
using AuctionProgram.Classes.Products;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuctionProgram.Classes
{
    public class Bidder : IObserver
    {
        private int id;
        private string name;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public Bidder(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        public void update(Product lot)
        {
            bool notificationShown = false;

            if (!notificationShown)
            {
                NotifyIcon notification = new NotifyIcon();
                notification.Icon = Properties.Resources.auctionIcon;
                notification.Text = "New bid change!";
                notification.Visible = true;
                notification.BalloonTipTitle = "Bid change!";
                notification.BalloonTipText = "New bid - " + lot.LastBid;
                notification.ShowBalloonTip(200);

                notification.Visible = false;

                notificationShown = true;
            }
        }
    }
}
