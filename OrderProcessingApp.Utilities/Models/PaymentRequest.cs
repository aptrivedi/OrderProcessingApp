using OrderProcessingApp.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Utilities.Models
{
    public class PaymentRequest
    {
        public Guid OrderId { get; set; }
        public PaymentProcessingTypes PaymentProcessingType { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsMembershipUpgradeRequest { get; set; }

    }
}
