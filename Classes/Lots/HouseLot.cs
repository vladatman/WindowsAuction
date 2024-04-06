using AuctionProgram.Classes.Products;
using System;

namespace AuctionProgram.Classes.Lots
{
    class HouseLot : Lot
    {
        private int id;
        private string location;
        private string style;
        private DateTime builtTime;
        private int money;
        private DateTime expTime;

        //GUI
        private MainForm mainForm;

        public HouseLot(int id, string location, string style, DateTime builtTime, int money, DateTime expTime, MainForm mainForm)
        {
            this.id = id;
            this.location = location;
            this.style = style;
            this.builtTime = builtTime;
            this.money = money;
            this.expTime = expTime;
            this.mainForm = mainForm;
        }

        public override Product createLot()
        {
            return new House(id, location, style, builtTime, money, expTime, mainForm);
        }
    }
}
