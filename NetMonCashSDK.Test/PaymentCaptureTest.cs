using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetMonCashSDK.Http;
using NetMonCashSDK.Model;
using System.Net;

namespace NetMonCashSDK.Test
{
    [TestClass]
    public class PaymentCaptureTest
    {
        [TestMethod]
        public void CaptureByTransactionIdTest()
        {
            ApiService apiService = new ApiService(CredentialTest.CLIENT_ID, CredentialTest.CLIENT_SECRET, Constants.SANDBOX);

            PaymentCapture capture = apiService.paymentCapture(new TransactionId("2153533068")).Result;

            Assert.IsNotNull(capture.status);

            if (capture.status != null && (capture.status.Equals($"{(int)HttpStatusCode.OK}") || capture.status.Equals($"{(int)HttpStatusCode.Accepted}")))
            {
                Console.WriteLine("Transaction");
                Console.WriteLine(capture.payment.message);
                Console.WriteLine($"TransactionId: {capture.payment.transaction_id}");
                Console.WriteLine($"Payer: {capture.payment.payer}");
                Console.WriteLine($"Amount: {capture.payment.cost}");
            }
            else
            {
                Console.WriteLine($"{capture.error} | {capture.error_description}");
            }

        }


        [TestMethod]
        public void CaptureByOrderIdTest()
        {
            ApiService apiService = new ApiService(CredentialTest.CLIENT_ID, CredentialTest.CLIENT_SECRET, Constants.SANDBOX);

            PaymentCapture capture = apiService.paymentCapture(new OrderId("9876543210")).Result;

            Assert.IsNotNull(capture.status);

            if (capture.status != null && (capture.status.Equals($"{(int)HttpStatusCode.OK}") || capture.status.Equals($"{(int)HttpStatusCode.OK}")))
            {
                Console.WriteLine("Transaction");
                Console.WriteLine(capture.payment.message);
                Console.WriteLine($"TransactionId: {capture.payment.transaction_id}");
                Console.WriteLine($"Payer: {capture.payment.payer}");
                Console.WriteLine($"Amount: {capture.payment.cost}");
            }
            else
            {
                Console.WriteLine($"{capture.error} | {capture.error_description}");
            }
        }
    }
}
