﻿using OrderProcessingApp.Engine.Interfaces;
using OrderProcessingApp.Utilities.Helpers;
using OrderProcessingApp.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Engine.Processors
{
    public class ProductProcessor : IPaymentProcessor
    {
        public void Process(PaymentRequest paymentRequest)
        {
            if (paymentRequest is null)
                throw new NullReferenceException("Payment request object is null.");

            GeneratePackageSlip();
            CommissionHelper.GenerateAgentCommisson();
        }

        private void GeneratePackageSlip()
        {
            //Logic to geenerate package slip.
        }

    }
}
