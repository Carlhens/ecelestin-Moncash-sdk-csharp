﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMonCashSDK.Model
{
    class OrderId
    {
        public String orderId { get; set; }

        public OrderId(String orderId)
        {
            this.orderId = orderId;
        }
    }
}
