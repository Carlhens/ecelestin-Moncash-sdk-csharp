using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetMonCashSDK.Http;
using NetMonCashSDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetMonCashSDK.Test
{

    [TestClass]
    public class TransfertTest
    {
        [TestMethod]
        public void MakeTransfertTest()
        {
            ApiService apiService = new ApiService(CredentialTest.CLIENT_ID, CredentialTest.CLIENT_SECRET, Constants.SANDBOX);

            Transfert transfert = new Transfert();
            transfert.receiver = "50936910311";
            transfert.amount = 10.0;
            transfert.desc = "Paiement de gain.";

            TransfertResult transfertResult = apiService.transfert(transfert).Result;

            if (transfertResult.status != null && transfertResult.status.Equals($"{(int)HttpStatusCode.OK}"))
            {
                Console.WriteLine($"transaction_id: {transfertResult.transfer.transaction_id}");
                Console.WriteLine($"receiver: {transfertResult.transfer.receiver}");
                Console.WriteLine($"amount: {transfertResult.transfer.amount}");
                Console.WriteLine($"message: {transfertResult.transfer.message}");
                Console.WriteLine($"desc: {transfertResult.transfer.desc}");
            }
            else if (transfertResult.status == null)
            {
                Console.WriteLine(transfertResult.error);
                Console.WriteLine(transfertResult.error_description);
            }
            else
            {
                Console.WriteLine(transfertResult.status);
                Console.WriteLine(transfertResult.error);
                Console.WriteLine(transfertResult.message);
                Console.WriteLine(transfertResult.path);
            }
        }
    }
}
