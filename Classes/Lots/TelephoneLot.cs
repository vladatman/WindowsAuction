using AuctionProgram.Classes.Products;
using System;

namespace AuctionProgram.Classes.Lots
{
    class TelephoneLot : Lot
    {
        private int id;
        private string brand;
        private string model;
        private string color;
        private int batteryPower;
        private int money;
        private DateTime expTime;

        //GUI
        private MainForm mainForm;

        public TelephoneLot(int id, string brand, string model, string color, int batteryPower, int money, DateTime expTime, MainForm mainForm)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.batteryPower = batteryPower;
            this.money = money;
            this.expTime = expTime;
            this.mainForm = mainForm;
        }

        public override Product createLot()
        {
            return new Telephone(id, brand, model, color, batteryPower, money, expTime, mainForm);
        }
    }
}
