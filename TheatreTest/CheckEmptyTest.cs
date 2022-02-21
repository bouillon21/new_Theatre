using Microsoft.VisualStudio.TestTools.UnitTesting;
using new_Theatre.Func;
using System;

namespace TheatreTest
{
    [TestClass]
    public class CheckEmptyTest
    {
        [TestMethod]
        public void CheckEmpty()
        {
            Utils util = new Utils();

            Assert.IsTrue(util.CheckEmpty(""));
            Assert.IsFalse(util.CheckEmpty("khe"));
        }
    }
}
