using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sendloop.Test {
    [TestClass]
    public class TestBase
    {
        protected SendloopManager _sendloopManager;

        [TestInitialize]
        public void Initialize() {
            _sendloopManager = new SendloopManager("{YOUR-SENDLOOP-API-KEY}");
        }
    }
}
