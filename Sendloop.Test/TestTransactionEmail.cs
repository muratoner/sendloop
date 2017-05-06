using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sendloop.Param.TransactionEmail;

namespace Sendloop.Test {
    [TestClass]
    public class TestTransactionEmail : TestBase {
        [TestMethod]
        public void TestSendEmail() {
            if (!CheckApiKey())
                return;

            //var res = SendloopManager.TransactionEmail.Send(new ParamTransactionEmailSend
            //{
            //    From = "from@mail.com",
            //    FromName = "From Name",
            //    ReplyTo = "replyto@mail.com",
            //    ReplyToName = "Reply To Name",
            //    Subject = "Subject",
            //    To = "to@mail.com",
            //    ToName = "To Name",
            //    HtmlBody = "<h1>Html Body</h1>"
            //});

            //Assert.IsNotNull(res, "res != null");
            //Assert.IsTrue(res.Success, "res.Success");
        }
    }
}
