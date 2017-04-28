namespace Sendloop.Test {

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Extension;
    using Model.Account;
    using Result.Account;

    [TestClass]
    public class TestAccount : TestBase {
        [TestMethod]
        public void TestGetInfo() {
            var res = _sendloopManager.Account.GetInfo();
            Assert.IsTrue(res.Success);
        }

        [TestMethod]
        public void TestGetApiKeyList() {
            var res = _sendloopManager.Account.GetApiKeyList();
            Assert.IsTrue(res.ApiKeys.Length > 0);
            Assert.IsTrue(res.Success);
        }

        [TestMethod]
        public void TestUpdateInfo() {
            var updatedData = new AccountInfoUpdate {
                CompanyName = "Test Company"
            };

            var accountInfo = _sendloopManager.Account.GetInfo();
            var resUpdate = _sendloopManager.Account.UpdateInfo(updatedData);

            Assert.IsTrue(resUpdate.Success);
            Assert.IsTrue(accountInfo.Success);
            TestUpdateInfoCompareValues(updatedData, accountInfo);

            updatedData.CompanyName = accountInfo.AccountInfo.CompanyName;

            resUpdate = _sendloopManager.Account.UpdateInfo(updatedData);
            accountInfo = _sendloopManager.Account.GetInfo();

            TestUpdateInfoCompareValues(updatedData, accountInfo);
        }

        private void TestUpdateInfoCompareValues(AccountInfoUpdate updatedData, ResultAccountInfo accountInfo)
        {
            if(updatedData.LastName.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.LastName, updatedData.LastName);

            if(updatedData.FirstName.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.FirstName, updatedData.FirstName);

            if(updatedData.City.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.City, updatedData.City);

            if(updatedData.State.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.State, updatedData.State);

            if(updatedData.CompanyName.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.CompanyName, updatedData.CompanyName);

            if(updatedData.TimeZone.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.TimeZone, updatedData.TimeZone);

            if(updatedData.Street.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Street, updatedData.Street);

            if(updatedData.Email.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Email, updatedData.Email);

            if(updatedData.Fax.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Fax, updatedData.Fax);

            if(updatedData.Website.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Website, updatedData.Website);

            if(updatedData.Username.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Username, updatedData.Username);

            if(updatedData.Country.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Country, updatedData.Country);

            if(updatedData.Phone.IsNotNullOrEmpty())
                Assert.AreEqual(accountInfo.AccountInfo.Phone, updatedData.Phone);
        }
    }
}