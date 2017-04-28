using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sendloop.Test {
    [TestClass]
    public class TestBase
    {
        protected SendloopManager SendloopManager;

        [TestInitialize]
        public void Initialize() {
            SendloopManager = new SendloopManager( "{YOUR-SENDLOOP-API-KEY}" );
        }
    }
}
