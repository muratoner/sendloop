namespace Sendloop.Test {

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestBase {
        protected SendloopManager SendloopManager;

        [TestInitialize]
        public void Initialize() {
            SendloopManager = new SendloopManager( "{YOUR-SENDLOOP-API-KEY}" );
        }
    }
}
