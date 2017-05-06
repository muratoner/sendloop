using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sendloop.Test {
    [TestClass]
    public class TestCampaign : TestBase {
        //[TestMethod]
        //public void TestCampaignGetListByStatus() {
        //    if ( !CheckApiKey() )
        //        return;
        //    var res = SendloopManager.Campaign.GetListByStatus( new ParamCampaignGetListByStatus {
        //        CampaignStatus = CampaignStatus.Sent
        //    } );

        //    Assert.IsNotNull(res, "res != null");
        //    Assert.IsTrue(res.Success, "res.Success");
        //}
        [TestMethod]
        public void TestCampaignGetList()
        {
            if (!CheckApiKey())
                return;

            var res = SendloopManager.Campaign.GetList();
            Assert.IsTrue(res.Success, "res.Success")
;        }
    }
}
