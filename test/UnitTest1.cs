using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmarAlshuaili_s00190262;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            Game game = new Game();
            decimal expected = 45;

            //ACT
            game.Price = 60;
            game.DecreasePrice(15);
            
            //ASSERT
            Assert.AreEqual(expected, game.Price);
        }
    }
}
