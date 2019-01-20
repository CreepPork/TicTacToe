using TicTacToe.Classes;

namespace TicTacToe
{
    internal static class Program
    {
        private static void Main()
        {
            Draw.Board();
            
            Draw.Tick(BoardPiece.TopLeft, Player.X);
        }
    }
}