using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMonCashSDK.Model
{
    public class TransfertDetails
    {
        public string transaction_id { get; set; }
        public double amount { get; set; }
        public string receiver { get; set; }
        public string message { get; set; }
        public string desc { get; set; }
    }
}
