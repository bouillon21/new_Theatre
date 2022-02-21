using Microsoft.VisualStudio.TestTools.UnitTesting;
using new_Theatre.Func;
using System;

namespace TheatreTest
{
    [TestClass]
    public class RegTest
    {
        [TestMethod]
        public void CheckRegistered()
        {
            DbBase DB = new DbBase();

            Assert.IsTrue(DB.CheckRegistered("0"));
            Assert.IsFalse(DB.CheckRegistered("1"));
        }
    }
}
