using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMonCashSDK.Model
{
    public class Transfert
    {
        public double amount { get; set; }
        public string receiver { get; set; }
        public string desc { get; set; }
    }
}
