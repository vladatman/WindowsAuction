using AuctionProgram.Classes.Products;
using System;

namespace AuctionProgram.Classes.Lots
{
    class CarLot : Lot
    {
        private int id;
        private string brand;
        private string model;
        private string color;
        private float totalKm;
        private int money;
        private DateTime expTime;

        //GUI
        private MainForm mainForm;

        public CarLot(int id, string brand, string model, string color, float totalKm, int money, DateTime expTime, MainForm mainForm)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.totalKm = totalKm;
            this.money = money;
            this.expTime = expTime;
            this.mainForm = mainForm;
        }

        public override Product createLot()
        {
            return new Car(id, brand, model, color, totalKm, money, expTime, mainForm);
        }
    }
}
