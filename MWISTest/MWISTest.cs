using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWISMakerLib;

namespace MWISTest
{
    [TestClass]
    public class MWISTest
    {
        [TestMethod]
        public void TestMWISMakerCase1()
        {
            MWISMaker mwisMaker = new MWISMaker();
            mwisMaker.AddVertex(1);
            mwisMaker.AddVertex(4);
            mwisMaker.AddVertex(5);
            mwisMaker.AddVertex(4);
            mwisMaker.Execute();
            Assert.AreEqual(1, mwisMaker.MWIS[0]);
            Assert.AreEqual(3, mwisMaker.MWIS[1]);
        }

        [TestMethod]
        public void TestMWISMakerCase2()
        {
            MWISMaker mwisMaker = new MWISMaker();
            mwisMaker.AddVertex(4);
            mwisMaker.AddVertex(1);
            mwisMaker.AddVertex(5);
            mwisMaker.AddVertex(4);
            mwisMaker.Execute();
            Assert.AreEqual(0, mwisMaker.MWIS[0]);
            Assert.AreEqual(2, mwisMaker.MWIS[1]);
        }
    }
}
