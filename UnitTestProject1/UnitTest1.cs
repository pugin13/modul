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
            Assert.AreEqual(vz.table_result[vz.table_result.GetLength(0) - 1, 0], -9,11111111111111);
        }
        [TestMethod]
        public void TestMethod2()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[vz.table_result.GetLength(0) - 1, 0] * -1, 9,11111111111111);
        }
        [TestMethod]
        public void TestMethod3()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[0, 0], 0,666666666666667);
        }
        [TestMethod]
        public void TestMethod4()
        {
            vvodZnach vz = new vvodZnach();
            vz.simplexBol();
            Assert.AreEqual(vz.table_result[2, 0], 0,888888888888889);
        }
    }
}

