using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BuildTowerTests
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", BuildTower.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", BuildTower.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", BuildTower.TowerBuilder(3)));
        }
    }
