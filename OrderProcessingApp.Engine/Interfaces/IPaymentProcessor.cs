using OrderProcessingApp.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Engine.Interfaces
{
    public interface IPaymentProcessor
    {
        void Process(PaymentRequest paymentRequest);
    }
}
