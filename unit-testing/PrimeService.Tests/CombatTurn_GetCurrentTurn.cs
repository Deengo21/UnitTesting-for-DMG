using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class CombatTurn_GetCurrentTurn
    {
        
        [Test]
        public void GetCurrentTurn_ReturnsNullIfNoPlayers()
        {
            CombatTurn combat = new CombatTurn (new List<string>());
            
         
           Assert.IsNull(combat.GetNextTurn(), "It should return Null - No players provided");
        }
        [Test]
        public void GetCurrentTurn_ReturnsFirstPlayerifOnePlayerPresent()
        {
            CombatTurn combat = new CombatTurn (new List<string>{"player1"});
            
            Assert.AreEqual("player1", combat.GetNextTurn(), "It should return Player1 - One player in combat");
        }
        [Test]
        public void GetCurrentTurn_ReturnsFirstPlayerThenTheNextPlayer()
        {
            CombatTurn combat = new CombatTurn (new List<string>{"player1","player2"});
            
            Assert.AreEqual("player1", combat.GetNextTurn(), "It should return Player1 - One player in combat");
            Assert.AreEqual("player2", combat.GetNextTurn(), "It should return Player2 - Two players in combat");
        }
        [Test]
        public void GetCurrentTurn_ReturnsFirstPlayerAfterSecondPlayer()
        {
            CombatTurn combat = new CombatTurn (new List<string>{"player1","player2"});
            
            Assert.AreEqual("player1", combat.GetNextTurn(), "It should return Player1 - One player in combat");
            Assert.AreEqual("player2", combat.GetNextTurn(), "It should return Player2 - Two players in combat");
            Assert.AreEqual("player1", combat.GetNextTurn(), "It should return Player1 - First player again in combat");
        }
    }

}