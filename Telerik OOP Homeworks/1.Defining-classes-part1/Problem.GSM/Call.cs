namespace Problem.GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Call
    {
        private string date;
        private string time;
        private int dialledPhoneNum;
        private int duration;

        public Call(string date, string time, int dialledPhone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNum = dialledPhone;
            this.Duration = duration;
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int DialledPhoneNum
        {
            get
            {
                return dialledPhoneNum;
            }

            set
            {
                dialledPhoneNum = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Date: {0}, Time: {1}, Dialled number: {2}, Duration: {3}", Date, Time, DialledPhoneNum, Duration);
        }
    }
}
