using System;

namespace TicTacToe.Classes
{
    public static class Draw
    {
        public static void Board()
        {
            /*
             *        |       |      
             *    o   |   o   |   x
             *        |       |
             * -------|-------|-------
             *        | ----- |
             *        | | x | |
             *        | ----- |
             * -------|-------|-------
             * 0123456|8912345|7891234
             *        |       |
             *        |       |
             * 
             */

            Console.WriteLine("       |       |       ");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("-------|-------|-------");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("-------|-------|-------");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("       |       |       ");
        }

        public static void Tick(BoardPiece boardPiece, Player player)
        {
            string playerSymbol = player.ToString().ToLowerInvariant();
            
            switch (boardPiece)
            {
                // Top
                case BoardPiece.TopLeft:
                    Console.SetCursorPosition(3, 1);
                    break;
                
                case BoardPiece.TopCenter:
                    Console.SetCursorPosition(11, 1);
                    break;
                
                case BoardPiece.TopRight:
                    Console.SetCursorPosition(19, 1);
                    break;
                
                // Middle
                case BoardPiece.MiddleLeft:
                    Console.SetCursorPosition(3, 5);
                    break;
                
                case BoardPiece.MiddleCenter:
                    Console.SetCursorPosition(11, 5);
                    break;
                
                case BoardPiece.MiddleRight:
                    Console.SetCursorPosition(19, 5);
                    break;
                
                // Bottom
                case BoardPiece.BottomLeft:
                    Console.SetCursorPosition(3, 9);
                    break;
                
                case BoardPiece.BottomCenter:
                    Console.SetCursorPosition(11, 9);
                    break;
                
                case BoardPiece.BottomRight:
                    Console.SetCursorPosition(19, 9);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(boardPiece), boardPiece, null);
            }

            Console.Write(playerSymbol);
                        
            // Reset to bottom. 
            Console.SetCursorPosition(0, Console.WindowTop + Console.WindowHeight - 1);
        }
        
        public static void RemoveTick(BoardPiece boardPiece)
        {
            throw new NotImplementedException();
        }

        public static void SelectSquare(BoardPiece boardPiece)
        {
            throw new NotImplementedException();
        }
    }
}