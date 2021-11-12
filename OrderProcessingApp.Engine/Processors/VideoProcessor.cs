using OrderProcessingApp.Engine.Interfaces;
using OrderProcessingApp.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Engine.Processors
{
    public class VideoProcessor : IPaymentProcessor
    {
        public void Process(PaymentRequest paymentRequest)
        {
            AddFreeVideo();
        }

        private void AddFreeVideo()
        {
            // Add free video "First Aid" to packaging slip.
        }
    }
}
