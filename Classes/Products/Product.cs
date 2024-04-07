using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuctionProgram.Classes.Products
{
    public abstract class Product : Panel
    {
        protected int id;
        protected DateTime expTime;
        protected Bidder lastBidder;
        protected int lastBid;
        protected List<IObserver> observers;
        protected bool isTracking = false;

        //GUI
        public Button buyButton;

        public int Id { get => id; set => id = value; }
        public DateTime ExpTime { get => expTime; set => expTime = value; }
        public Bidder LastBidder { get => lastBidder; set => lastBidder = value; }
        public int LastBid { get => lastBid; set => lastBid = value; }
        public List<IObserver> Observers { get => observers; set => observers = value; }
        public bool IsTracking { get => isTracking; set => isTracking = value; }

        public abstract void render();
        public abstract void bid();
        public abstract void showInfo();
        public abstract void setLastBid(int money);
        public abstract void changeTrack();
        public abstract void checkTrack();
    }
}
