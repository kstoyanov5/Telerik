using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.GSM
{
    public class Display
    {
        private string size;
        private string numberOfColors;

        public Display(string size, string numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public string Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public string NumberOfColors
        {
            get
            {
                return numberOfColors;
            }

            set
            {
                numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("size:{0}, Number of colors:{1}", Size, NumberOfColors);
        }
    }
}
