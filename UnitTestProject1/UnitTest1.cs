using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[vz.table_result.GetLength(0) - 1, 0], -45.6);
        }
        [TestMethod]
        public void TestMethod2()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[vz.table_result.GetLength(0) - 1, 0] * -1, 45.6);
        }
        [TestMethod]
        public void TestMethod3()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[0, 0], 5.6);
        }
        [TestMethod]
        public void TestMethod4()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[2, 0], 0.4);
        }
    }
}

