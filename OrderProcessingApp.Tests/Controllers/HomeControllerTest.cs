using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingApp;
using OrderProcessingApp.Controllers;
using OrderProcessingApp.Engine.Processors;
using OrderProcessingApp.Utilities.Models;

namespace OrderProcessingApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        PaymentRequest moqPaymentRequest;

        [TestInitialize]
        public void TestInitialize()
        {
            moqPaymentRequest = new PaymentRequest()
            {
                OrderId = Guid.NewGuid(),
                TotalAmount = 100
            };
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void ProcessUpgradeMembershipPayment()
        {
            try
            {
                moqPaymentRequest.PaymentProcessingType = Utilities.Enums.PaymentProcessingTypes.Membership;
                   
                PaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();
                var paymentProcessor = paymentProcessorFactory.GetProcessor(Utilities.Enums.PaymentProcessingTypes.Membership);
                paymentProcessor.Process(moqPaymentRequest);
                return;
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProcessBookPaymentNullObject()
        {
            try
            {
                PaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();
                var paymentProcessor = paymentProcessorFactory.GetProcessor(Utilities.Enums.PaymentProcessingTypes.Book);
                paymentProcessor.Process(null);
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProcessBookPayment()
        {
            try
            {
                moqPaymentRequest.PaymentProcessingType = Utilities.Enums.PaymentProcessingTypes.Book;

                PaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();
                var paymentProcessor = paymentProcessorFactory.GetProcessor(Utilities.Enums.PaymentProcessingTypes.Book);
                paymentProcessor.Process(moqPaymentRequest);
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProcessVideoPayment()
        {
            try
            {
                moqPaymentRequest.PaymentProcessingType = Utilities.Enums.PaymentProcessingTypes.Video;

                PaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();
                var paymentProcessor = paymentProcessorFactory.GetProcessor(Utilities.Enums.PaymentProcessingTypes.Video);
                paymentProcessor.Process(moqPaymentRequest);
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProcessProductPayment()
        {
            try
            {
                moqPaymentRequest.PaymentProcessingType = Utilities.Enums.PaymentProcessingTypes.Product;

                PaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();
                var paymentProcessor = paymentProcessorFactory.GetProcessor(Utilities.Enums.PaymentProcessingTypes.Product);
                paymentProcessor.Process(moqPaymentRequest);
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }


    }
}
