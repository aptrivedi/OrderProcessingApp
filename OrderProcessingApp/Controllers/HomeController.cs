using OrderProcessingApp.Engine.Processors;
using OrderProcessingApp.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderProcessingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PaymentRequest paymentRequest = new PaymentRequest()
            {
                OrderId = Guid.NewGuid(),
                PaymentProcessingType = Utilities.Enums.PaymentProcessingTypes.Product,
                TotalAmount = 100
            };
            PaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();
            var paymentProcessor = paymentProcessorFactory.GetProcessor(Utilities.Enums.PaymentProcessingTypes.Product);
            paymentProcessor.Process(paymentRequest);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}