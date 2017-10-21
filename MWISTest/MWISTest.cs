using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWISMakerLib;

namespace MWISTest
{
    [TestClass]
    public class MWISTest
    {
        [TestMethod]
        public void TestMWISMaker()
        {
            MWISMaker mwisMaker = new MWISMaker();
            mwisMaker.AddVertex(1);
            mwisMaker.AddVertex(4);
            mwisMaker.AddVertex(5);
            mwisMaker.AddVertex(4);
            mwisMaker.Execute();
            Assert.AreEqual(4, mwisMaker.MWIS[0]);
            Assert.AreEqual(4, mwisMaker.MWIS[1]);
        }
    }
}
