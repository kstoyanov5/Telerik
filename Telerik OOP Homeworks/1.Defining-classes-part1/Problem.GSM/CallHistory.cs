using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.GSM
{
    public class CallHistory
    {
        List<Call> phoneCallHistory = new List<Call>();

        public CallHistory(List<Call> phoneCallHistory)
        {
            this.PhoneCallHistory = phoneCallHistory;
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
    }
}
