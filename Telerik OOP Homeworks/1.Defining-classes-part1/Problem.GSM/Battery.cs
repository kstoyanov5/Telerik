namespace Problem.GSM
{
    public class Battery
    {
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        };

        private BatteryType type;
        private string model;
        private string hoursIdle;
        private string hoursTalked;

        public Battery(BatteryType type)
        {
            this.type = type;
            model = null;
            hoursIdle = null;
            hoursTalked = null;
        }

        public Battery(BatteryType type, string model, string hoursIdle, string hoursTalked)
        {
            this.type = type;
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalked = hoursTalked;
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public string HoursTalked
        {
            get { return this.hoursTalked; }
            set { this.hoursTalked = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, Battery Model:{1}, Hours Idle:{2}, Hours Talked:{3}", Type, Model, HoursIdle, HoursTalked);
        }
    }
}
