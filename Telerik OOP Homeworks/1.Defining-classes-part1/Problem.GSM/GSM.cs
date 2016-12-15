namespace Problem.GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private string price;
        private string owner;
        private Battery battery;
        private Display display;

        List<Call> phoneCallHistory = new List<Call>();

        private static GSM Iphone4S = new GSM("Iphone4S", "Apple", "450lv", "Pesho", new Battery(Battery.BatteryType.LiIon), new Display("480p", "10000000"));

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public GSM(string model, string manufacturer, string price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return battery;
            }

            set
            {
                battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return display;
            }

            set
            {
                display = value;
            }
        }

        public static GSM Iphone4
        {
            get
            {
                return Iphone4S;
            }

            set
            {
                Iphone4S = value;
            }
        }

        public List<Call> PhoneCallHistory
        {
            get
            {
                return phoneCallHistory;
            }

            set
            {
                phoneCallHistory = value;
            }
        }

        public void addCall(Call call)
        {
            PhoneCallHistory.Add(call);
        }

        public void deleteCall(Call call)
        {
            PhoneCallHistory.Remove(call);
        }

        public void clearCallHistory()
        {
            foreach (var call in PhoneCallHistory)
            {
                PhoneCallHistory.Remove(call);
            }
        }

        public override string ToString()
        {
            return string.Format("GSM Model: {0}, Manufacturer: {1}, Price: {2}, Owner Name: {3}, Battery type: {4}, Display {5}", Model, Manufacturer, Price, Owner, Battery.ToString(), Display.ToString());
        }
    }
}
