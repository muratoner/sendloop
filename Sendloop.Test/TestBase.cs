using Sendloop.Core;

namespace Sendloop.Test {

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestBase {
        protected SendloopManager SendloopManager;

        [TestInitialize]
        public void Initialize() {
            SendloopManager = new SendloopManager( "{YOUR-SENDLOOP-API-KEY}" );
        }

        protected bool CheckApiKey()
        {
            if (SendloopInfo.ApiKey.Equals( "{YOUR-SENDLOOP-API-KEY}" )) {
                Assert.Fail("Invalid api key. Please enter valid key. If you want new api key then visit this url(http://[your-account-key].sendloop.com/settings/api/)");
            }
            return true;
        }
    }
}
