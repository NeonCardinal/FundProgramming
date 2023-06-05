using System;
using System.Collections.Generic;
using System.Text;

namespace CellPhone
{
    public class Gsm
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }
        public Battery Battery { get => battery; set => battery = value; }
        public Display Display { get => display; set => display = value; }

        public Gsm()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Price = 0.00;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public Gsm(string model, string manufacturer, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public Gsm(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString()
        {
            return this.Model + " " + Manufacturer + " " + Price + " " + Owner + " " + Battery.Model + " " + Display;
        }
    }
}
