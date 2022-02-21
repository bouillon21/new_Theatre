using Microsoft.VisualStudio.TestTools.UnitTesting;
using new_Theatre.Func;
using System;

namespace TheatreTest
{
    [TestClass]
    public class SingInTest
    {
        [TestMethod]
        public void SingIn()
        {
            DbBase DB = new DbBase();

            Assert.IsTrue(DB.SingIn("1", "1"));
            Assert.IsFalse(DB.SingIn("0", "0"));
        }
    }
}
