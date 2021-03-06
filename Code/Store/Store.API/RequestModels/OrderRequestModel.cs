﻿using System;
using System.Collections.Generic;

namespace Store.API.RequestModels
{
    public class OrderRequestModel
    {
        public int? OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? CustomerID { get; set; }

        public decimal? Total { get; set; }

        public short? CurrencyID { get; set; }

        public Guid PaymentMethodID { get; set; }

        public string Comments { get; set; }

        public string CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public List<OrderDetailRequestModel> Details { get; set; }
    }
}
