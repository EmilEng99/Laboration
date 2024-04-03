using ConnectFour;
using static ConnectFour.GameState;

namespace CheckForWin___UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            GameState gameState = new GameState();

            var result = gameState.CheckForWin();

            Assert.Equal(WinState.No_Winner, result);
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            GameState gameState = new GameState();

            gameState.SetBoard(new List<int>
            {
                1, 1, 2, 2, 1, 1, 2,
                2, 2, 1, 1, 2, 2, 1,
                1, 1, 2, 2, 1, 1, 2,
                2, 2, 1, 1, 2, 2, 1,
                1, 1, 2, 2, 1, 1, 2,
                2, 2, 1, 1, 2, 2, 1
            });

            var result = gameState.CheckForWin();

            Assert.Equal(WinState.Tie, result);
        }
    }
}