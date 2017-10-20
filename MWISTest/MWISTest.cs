using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MWISTest
{
    [TestClass]
    public class MWISTest
    {
        [TestMethod]
        public void TestMWISMaker()
        {
            TestMWISMaker mwisMaker = new MSIWMaker();
            mwisMaker.AddVertex(1);
            mwisMaker.AddVertex(4);
            mwisMaker.AddVertex(5);
            mwisMaker.AddVertex(4);
            Assert.AreEqual(4, mwisMaker.MWIS[0]);
            Assert.AreEqual(4, mwisMaker.MWIS[1]);
        }
    }
}
