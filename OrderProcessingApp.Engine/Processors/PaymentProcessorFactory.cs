using OrderProcessingApp.Engine.Interfaces;
using OrderProcessingApp.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Engine.Processors
{
    public class PaymentProcessorFactory
    {
        private readonly Dictionary<PaymentProcessingTypes, IPaymentProcessor> dcPaymentProcessors = new Dictionary<PaymentProcessingTypes, IPaymentProcessor>();
        public PaymentProcessorFactory()
        {
            dcPaymentProcessors.Add(PaymentProcessingTypes.Product, new ProductProcessor());
            dcPaymentProcessors.Add(PaymentProcessingTypes.Book, new BookProcessor());
            dcPaymentProcessors.Add(PaymentProcessingTypes.Membership, new MembershipProcessor());
            dcPaymentProcessors.Add(PaymentProcessingTypes.Video, new VideoProcessor());
        }

        public IPaymentProcessor GetProcessor(PaymentProcessingTypes paymentProcessingType)
        {
            dcPaymentProcessors.TryGetValue(paymentProcessingType, out IPaymentProcessor paymentProcessor);
            return paymentProcessor;
        }
    }
}
