using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class testStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
    }
}
