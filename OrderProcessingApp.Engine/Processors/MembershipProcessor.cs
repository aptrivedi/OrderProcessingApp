using OrderProcessingApp.Engine.Interfaces;
using OrderProcessingApp.Utilities.Helpers;
using OrderProcessingApp.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Engine.Processors
{
    public class MembershipProcessor : IPaymentProcessor
    {
        public void Process(PaymentRequest paymentRequest)
        {
            if (paymentRequest.IsMembershipUpgradeRequest)
                MembershipHelper.UpgradeMembership();

            MembershipHelper.ActivateMembership();
            SendEmailNotification();
        }

        private void SendEmailNotification()
        {
            //Logic to send email notification to owner of membership regarding activation/upgrade.
        }
    }
}
