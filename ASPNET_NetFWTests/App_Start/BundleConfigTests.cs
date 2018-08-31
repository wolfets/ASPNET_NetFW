using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPNET_NetFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_NetFW.Tests
{
    [TestClass()]
    public class BundleConfigTests
    {
        [TestMethod()]
        public void RegisterBundlesTest()
        {
            BundleConfig bundle = new BundleConfig();
            Assert.IsTrue(bundle != null);
        }
    }
}