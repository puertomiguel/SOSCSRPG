using Engine.ViewModels;
using Engine.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestEngine.ViewModels
{
    [TestClass]
    public class TestGameSession
    {
        [TestMethod]
        public void TestCreateGameSession()
        {
            GameSession gameSession = new GameSession();

            Assert.IsNotNull(gameSession.CurrentPlayer);
            Assert.AreEqual("Town square", gameSession.CurrentLocation.Name);
        }

        [TestMethod]
        public void TestPlayerMovesHomeAndIsCompletelyHealedOnKilled()
        {
            GameSession gameSession = new GameSession();

            gameSession.CurrentPlayer.TakeDamage(999);

            Assert.AreEqual("Home", gameSession.CurrentLocation.Name);
            Assert.AreEqual(gameSession.CurrentPlayer.Level * 10, gameSession.CurrentPlayer.CurrentHitPoints);
        }

        [TestMethod]
        public void TestAddItemToInventory()
        {
            GameSession gameSession = new GameSession();

            gameSession.CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(9001));

            Assert.IsTrue(gameSession.CurrentPlayer.Inventory.Any(item => item.ItemTypeID == 9001));
            Assert.IsTrue(gameSession.CurrentPlayer.GroupedInventory.Any(gi => gi.Item.ItemTypeID == 9001));
        }
    }
}
